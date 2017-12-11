﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrapeCity.Documents.Spread.Examples.SpreadSheetsViewer
{
    public class FamilyBudget : ExampleBase
    {
        public override void Execute(GrapeCity.Documents.Spread.Workbook workbook)
        {
            //Load template file
            var fileStream = this.GetTemplateStream("Family budget.xlsx");
            workbook.Open(fileStream);
        }

        public override string TemplateName
        {
            get
            {
                return "Family budget.xlsx";
            }
        }

        public override bool HasTemplate
        {
            get
            {
                return true;
            }
        }

        public override bool IsViewReadOnly
        {
            get
            {
                return false;
            }
        }

        public override bool ShowCode
        {
            get
            {
                return false;
            }
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
