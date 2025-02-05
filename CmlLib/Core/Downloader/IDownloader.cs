﻿using System.ComponentModel;

namespace CmlLib.Core.Downloader
{
    public interface IDownloader
    {
        Task DownloadFiles(DownloadFile[] files,
            IProgress<DownloadFileChangedEventArgs>? fileProgress,
            IProgress<ProgressChangedEventArgs>? downloadProgress);
    }
}
