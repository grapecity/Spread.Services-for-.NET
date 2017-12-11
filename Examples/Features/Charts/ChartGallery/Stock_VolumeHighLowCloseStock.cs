﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrapeCity.Documents.Spread.Examples.Features.Charts.ChartGallery
{
   public class Stock_VolumeHighLowCloseStock:ExampleBase
    {
        public override void Execute(GrapeCity.Documents.Spread.Workbook workbook)
        {
            IWorksheet worksheet = workbook.Worksheets[0];
            GrapeCity.Documents.Spread.Drawing.IShape shape = worksheet.Shapes.AddChart(GrapeCity.Documents.Spread.Drawing.ChartType.StockVHLC, 350, 20, 360, 230);
            worksheet.Range["A1:E17"].Value = new object[,] {
                { null, "Volume", "High", "Low", "Close" },
                { new DateTime(2008, 9, 1), 26085,  105.76, 92.38, 100.94 },
                { new DateTime(2008, 9, 2), 52314,  102.45, 90.14, 93.45 },
                { new DateTime(2008, 9, 3), 70308, 102.11, 85.01, 99.89 },
                { new DateTime(2008, 9, 4), 33401,  106.01, 94.04, 99.45 },
                { new DateTime(2008, 9, 5), 87500,  108.23, 98.16, 104.33 },
                { new DateTime(2008, 9, 8), 33756,  107.7, 91.02, 102.17 },
                { new DateTime(2008, 9, 9), 65737,  110.36, 101.62, 110.07 },
                { new DateTime(2008, 9, 10), 45668, 115.97, 106.89, 112.39 },
                { new DateTime(2008, 9, 11), 47815, 120.32, 112.15, 117.52 },
                { new DateTime(2008, 9, 12), 76759, 122.03, 114.67, 114.75 },
                { new DateTime(2008, 9, 15), 23492, 120.46, 106.21, 116.85 },
                { new DateTime(2008, 9, 16), 56127, 118.08, 113.55, 116.69 },
                { new DateTime(2008, 9, 17), 81142, 128.23, 110.91, 117.25 },
                { new DateTime(2008, 9, 18), 46384, 120.55, 108.09, 112.52 },
                { new DateTime(2008, 9, 19), 51005, 112.58, 105.42, 109.12 },
                { new DateTime(2008, 9, 22), 35223, 115.23, 97.25, 101.56 },
            };
            shape.Chart.SeriesCollection.Add(worksheet.Range["A1:E17"], GrapeCity.Documents.Spread.Drawing.RowCol.Columns);
            shape.Chart.ChartTitle.Text = "Volume-High-Low-Close Stock Chart";
            shape.Chart.LineGroups[0].HiLoLines.Format.Line.Color.RGB = Color.Black;
            GrapeCity.Documents.Spread.Drawing.IAxis valueAxis = shape.Chart.Axes.Item(GrapeCity.Documents.Spread.Drawing.AxisType.Value);
            GrapeCity.Documents.Spread.Drawing.IAxis categoryAxis = shape.Chart.Axes.Item(GrapeCity.Documents.Spread.Drawing.AxisType.Category);
            GrapeCity.Documents.Spread.Drawing.IAxis valueSecondaryAxis = shape.Chart.Axes.Item(GrapeCity.Documents.Spread.Drawing.AxisType.Value, GrapeCity.Documents.Spread.Drawing.AxisGroup.Secondary);
            GrapeCity.Documents.Spread.Drawing.ISeries series_close = shape.Chart.SeriesCollection[3];
            //config value axis
            valueAxis.MinimumScale = 0;
            valueAxis.MaximumScale = 150000;
            valueAxis.MajorUnit = 30000;
            //config category axis
            categoryAxis.CategoryType = GrapeCity.Documents.Spread.Drawing.CategoryType.CategoryScale;
            categoryAxis.MajorTickMark = GrapeCity.Documents.Spread.Drawing.TickMark.Outside;
            categoryAxis.TickLabelSpacing = 4;
            //config secondary value axis
            valueSecondaryAxis.MinimumScale = 0;
            valueSecondaryAxis.MaximumScale = 150;
            valueSecondaryAxis.MajorUnit = 30;
            //config marker style
            series_close.MarkerFormat.Fill.Color.RGB = Color.Orange;
            series_close.MarkerStyle = GrapeCity.Documents.Spread.Drawing.MarkerStyle.Square;
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
