﻿//
// Community Forums
// Copyright (c) 2013-2024
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
namespace DotNetNuke.Modules.ActiveForums
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;

    public partial class af_polledit : ForumBase
    {
        private string _pollQuestion = "";
        private string _pollType = "";
        private string _pollOptions = "";

        public string PollQuestion
        {
            get
            {
                return this._pollQuestion;
            }

            set
            {
                this._pollQuestion = value;
            }
        }

        public string PollType
        {
            get
            {
                return this._pollType;
            }

            set
            {
                this._pollType = value;
            }
        }

        public string PollOptions
        {
            get
            {
                return this._pollOptions;
            }

            set
            {
                this._pollOptions = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!this.Page.IsPostBack)
            {
                this.txtPollQuestion.Text = this.PollQuestion;
                this.rdPollType.SelectedIndex = this.rdPollType.Items.IndexOf(this.rdPollType.Items.FindByValue(this.PollType));
                this.txtPollOptions.Text = this.PollOptions;
            }
        }
    }
}
