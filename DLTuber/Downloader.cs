using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
/// <summary>
/// Author: Manish Mallavarapu, Eric Lau 
/// Updated: 03/18/2016, by Manish Mallavarapu
/// </summary>
namespace DLTuber
{
    /// <summary>
    /// This class Downloads YouTube videos in the specified formats
    /// </summary>
    class Downloader
    {
        /// <summary>
        /// Private constructor to prevent instantiation
        /// Singleton pattern
        /// </summary>
        private Downloader()
        {
         
        }
        /// <summary>
        /// Downloads the YouTube video to a .mp4 errors
        /// </summary>
        /// <param name="v"></param>
        /// <param name="url"></param>
        /// <param name="dir"></param>
        /// <param name="progressBar1"></param>
        public static void downloadVideo(string v, string url, string dir,ProgressBar progressBar1)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(url);
            /*
            * Select the first .mp4 video with 360p resolution
            */
            VideoInfo video = videoInfos
                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the video downloader.
             * The first argument is the video to download.
             * The second argument is the path to save the video file.
             */
            var videoDownloader = new VideoDownloader(video, dir);
            // Register the ProgressChanged event and print the current progress
            videoDownloader.DownloadProgressChanged += (sender, args) => progressBar1.Invoke((Action)(() => { progressBar1.Value = (int)(args.ProgressPercentage); }));

            /*
             * Execute the video downloader.
             * For GUI applications note, that this method runs synchronously.
             */

            try
            {
                videoDownloader.Execute();
            }
            catch (WebException e)
            {
                MessageBox.Show("The video returned an error, please try again later",
                                 e.Response.ToString(),
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        ///  Downloads the YouTube video to a .mp3 format
        /// </summary>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="path"></param>
        /// <param name="progressBar1"></param>
        /// <param name="progressBar"></param>
        public static void downloadAudio(string type, string url, string path,ProgressBar progressBar)
        {
            if (path != " ")
            {
                //Parameter for video type
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(url);
                VideoInfo video = videoInfos.Where(info => info.CanExtractAudio).OrderByDescending(info => info.AudioBitrate).First();
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }
                var audioDownloader = new AudioDownloader(video, path);
                
                //audioDownloader.DownloadProgressChanged += (sender, args) => progressBar1.Invoke((Action)(() => { progressBar1.Value = (int)(args.ProgressPercentage * 0.85); })); 
                //audioDownloader.AudioExtractionProgressChanged += (sender, args) => progressBar1.Invoke((Action)(() => { progressBar1.Value = (int)(85 + args.ProgressPercentage * 0.15); }));
                audioDownloader.DownloadProgressChanged += (sender, args) => progressBar.Invoke((Action)(() => { progressBar.Value = (int)(args.ProgressPercentage * 0.85); }));
                audioDownloader.AudioExtractionProgressChanged += (sender, args) => progressBar.Invoke((Action)(() => { progressBar.Value = (int)(85 + args.ProgressPercentage * 0.15); }));

                audioDownloader.Execute();
            }
        }
    }
}
