﻿/*
 * This file is part of MemorySharp.
 * Copyright (C) 2012-2013 Jämes Ménétrey (a.k.a. ZenLulz).
 * <http://www.binarysharp.com/> <zenlulz@binarysharp.com>
 * 
 * This library is licensed under the GNU GPLv3 License.
 * See the file LICENSE for more information.
*/

using System;
using Binarysharp.MemoryManagement.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemorySharpTests.Helpers
{
    [TestClass]
    public class SingletonTests
    {
        /// <summary>
        /// Tests the singleton pattern implementation.
        /// </summary>
        [TestMethod]
        public void ReallySingleton()
        {
            Assert.AreSame(Singleton<Object>.Instance, Singleton<Object>.Instance);
        }
    }
}
