﻿using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels.Enums;

namespace MediaLibrary.Implementation.DataModels.DataModelsImplementation
{
    public sealed class Music : File
    {

        /// <summary>
        /// Year of release
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// Author of a song
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Length of a song
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Genre of a song
        /// </summary>
        public string Genre { get; set; }
        public override MediaFileTypes Type// переопределение типа файла
        {
            get => base.Type = MediaFileTypes.mp3;
            set => base.Type = value;
        }
    }
}