﻿//
// Community Forums
// Copyright (c) 2013-2021
// by DNN Community
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
//
<<<<<<<< HEAD:Dnn.CommunityForums/Entities/LikeInfo.cs
using DotNetNuke.ComponentModel.DataAnnotations;
========
>>>>>>>> dev81/3-dal2/3-filtercontroller:Dnn.CommunityForums/Deprecated/FilterInfo.cs
using System;
using System.Web.Caching;
namespace DotNetNuke.Modules.ActiveForums
{
<<<<<<<< HEAD:Dnn.CommunityForums/Entities/LikeInfo.cs
    [Obsolete("Deprecated in Community Forums. Scheduled removal in 09.00.00. Replace with DotNetNuke.Modules.ActiveForums.Entities.Likes")]
    class Likes : DotNetNuke.Modules.ActiveForums.Entities.LikeInfo { }
}
namespace DotNetNuke.Modules.ActiveForums.Entities
{
    [TableName("activeforums_Likes")]
    [PrimaryKey("Id", AutoIncrement = true)]
    [Scope("PostId")]
    [Cacheable("activeforums_Likes", CacheItemPriority.Normal)]
    class LikeInfo
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public bool Checked { get; set; }
    }
========
	public class FilterInfo : DotNetNuke.Modules.ActiveForums.Entities.FilterInfo;
>>>>>>>> dev81/3-dal2/3-filtercontroller:Dnn.CommunityForums/Deprecated/FilterInfo.cs
}
