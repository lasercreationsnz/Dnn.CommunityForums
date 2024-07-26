﻿// Community Forums
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

    public partial class admin_templates_new : ActiveAdminBase
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            this.agTemplates.Callback += this.agTemplates_Callback;
            this.agTemplates.ItemBound += this.agTemplates_ItemBound;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SettingsInfo moduleSettings = SettingsBase.GetModuleSettings(this.ModuleId);
            this.txtThemeName.Text = moduleSettings.Theme;
            this.txtTemplateFolder.Text = this.Server.MapPath(moduleSettings.TemplatePath);
        }

        private void agTemplates_Callback(object sender, Controls.CallBackEventArgs e)
        {
            int pageIndex = Convert.ToInt32(e.Parameters[0]);
            int pageSize = Convert.ToInt32(e.Parameters[1]);
            int rowIndex = 0;
            if (pageIndex == 0)
            {
                rowIndex = 0;
            }
            else
            {
                rowIndex = ((pageIndex + 1) * pageSize) - pageSize;
            }

            this.agTemplates.Datasource = DataProvider.Instance().Templates_List(this.PortalId, this.ModuleId, 0, rowIndex, pageSize);
            this.agTemplates.Refresh(e.Output);
        }

        private void agTemplates_ItemBound(object sender, Modules.ActiveForums.Controls.ItemBoundEventArgs e)
        {
            string sValue = string.Empty;
            try
            {
                sValue = this.GetSharedResource("[RESX:" + Convert.ToString(Enum.Parse(typeof(Templates.TemplateTypes), e.Item[1].ToString())) + "]");
            }
            catch (Exception ex)
            {
                sValue = e.Item[1].ToString();
            }

            e.Item[1] = sValue;
        }
    }
}
