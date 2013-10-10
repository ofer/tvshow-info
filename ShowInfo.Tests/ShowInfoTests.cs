﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShowInfoProvider;

namespace ShowInfo.Tests
{
    [TestClass]
    public class ShowInfoTests
    {
        [TestMethod]
        public void ForFilename_WithValidFileName_ReturnsTVEpisodeInfo()
        {
            //  Arrange
            ShowInformationManager showMgr = new ShowInformationManager();
            string filename = "Once.Upon.a.Time.S03E01.720p.HDTV.X264-DIMENSION.mkv";

            //  Act
            TVEpisodeInfo episode = showMgr.GetEpisodeInfoForFilename(filename);

            //  Assert
            Assert.AreEqual<int>(3, episode.SeasonNumber);
            Assert.AreEqual<int>(1, episode.EpisodeNumber);
            Assert.AreEqual<string>("Once Upon a Time", episode.ShowName);
            Assert.AreEqual<string>("The Heart of the Truest Believer", episode.EpisodeTitle);
        }
    }
}
