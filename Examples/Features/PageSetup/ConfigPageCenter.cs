﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrapeCity.Documents.Spread.Examples.Features.PageSetup
{
    public class ConfigPageCenter : ExampleBase
    {
        public override void Execute(GrapeCity.Documents.Spread.Workbook workbook)
        {
            var fileStream = this.GetTemplateStream("PageSetup Demo.xlsx");
            workbook.Open(fileStream);
            IWorksheet worksheet = workbook.Worksheets[0];

            //Set center, default is false.
            worksheet.PageSetup.CenterHorizontally = true;
            worksheet.PageSetup.CenterVertically = true;

        }

        public override bool IsNew
        {
            get
            {
                return true;
            }
        }
    }
}
