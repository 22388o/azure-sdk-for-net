﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    [CodeGenModel("DocumentLine")]
    public partial class DocumentLine
    {
        /// <summary>
        /// Initializes a new instance of DocumentLine. Used by the <see cref="DocumentAnalysisModelFactory"/>.
        /// </summary>
        internal DocumentLine(string content, IReadOnlyList<PointF> boundingPolygon, IReadOnlyList<DocumentSpan> spans)
        {
            Content = content;
            BoundingPolygon = boundingPolygon;
            Spans = spans;
        }

        /// <summary>
        /// The polygon that outlines the content of this line. Coordinates are specified relative to the
        /// top-left of the page, and points are ordered clockwise from the left relative to the line
        /// orientation. Units are in pixels for images and inches for PDF. The <see cref="LengthUnit"/>
        /// type of a recognized page can be found at <see cref="DocumentPage.Unit"/>.
        /// </summary>
        public IReadOnlyList<PointF> BoundingPolygon { get; private set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IReadOnlyList<float> Polygon
        {
            get => throw new InvalidOperationException();
            set
            {
                BoundingPolygon = ClientCommon.CovertToListOfPointF(value);
            }
        }
    }
}
