﻿using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using MyTunes.Shared;

namespace MyTunes
{
	public static class SongLoader
	{
		const string Filename = "songs.json";
        public static IStreamLoader loader { get; set; }

        public static async Task<IEnumerable<Song>> Load()
		{
			using (var reader = new StreamReader(OpenData())) {
                var songs = JsonConvert.DeserializeObject<List<Song>>(await reader.ReadToEndAsync());
                foreach(var song in songs) { song.Name = song.Name.RuinSongName(); }
				return songs;
			}
		}

		private static Stream OpenData()
		{
            if (null == loader) throw new System.Exception("An IStreamLoader must be set prior to using this class.");
            else return loader.GetStreamForFilename(Filename);
		}
	}
}

