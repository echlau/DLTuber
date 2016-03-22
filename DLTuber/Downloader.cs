using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace DLTuber
{
    class Downloader
    {
        private Downloader()
        {
         
        }
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
        public static void downloadAudio(string type, string url, string path,ProgressBar progressBar1, ProgressBar childprogress)
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
                audioDownloader.DownloadProgressChanged += (sender, args) => childprogress.Invoke((Action)(() => { childprogress.Value = (int)(args.ProgressPercentage * 0.85); }));
                audioDownloader.AudioExtractionProgressChanged += (sender, args) => childprogress.Invoke((Action)(() => { childprogress.Value = (int)(85 + args.ProgressPercentage * 0.15); }));

                audioDownloader.Execute();
            }
        }
    }
}
