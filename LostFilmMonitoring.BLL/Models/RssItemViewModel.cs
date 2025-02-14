﻿// <copyright file="RssItemViewModel.cs" company="Alexander Panfilenok">
// MIT License
// Copyright (c) 2021 Alexander Panfilenok
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the 'Software'), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </copyright>

namespace LostFilmMonitoring.BLL.Interfaces.Models
{
    using System.IO;
    using LostFilmMonitoring.DAO.Interfaces.DomainModels;

    /// <summary>
    /// View model for individual rss item. Contains torrent file.
    /// </summary>
    public class RssItemViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RssItemViewModel"/> class.
        /// </summary>
        /// <param name="torrentFile">Torrent file.</param>
        public RssItemViewModel(TorrentFile torrentFile)
        {
            this.TorrentFileBody = torrentFile.Stream;
            this.TorrentFileName = torrentFile.FileName;
        }

        /// <summary>
        /// Gets Torrent file body.
        /// </summary>
        public Stream TorrentFileBody { get; }

        /// <summary>
        /// Gets Torrent file name.
        /// </summary>
        public string TorrentFileName { get; }

        /// <summary>
        /// Gets Torrent file content type.
        /// </summary>
        public string ContentType { get; } = "application/x-bittorrent";
    }
}
