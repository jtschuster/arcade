// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Microsoft.DotNet.DarcLib
{
    public class DependencyGraphNode
    {
        public DependencyGraphNode(DependencyDetail dependencyDetail)
        {
            DependencyDetail = dependencyDetail;
            VisitedNodes = new HashSet<string>();
            ChildNodes = new List<DependencyGraphNode>();
        }

        public DependencyGraphNode(DependencyDetail dependencyDetail, HashSet<string> visitedNodes) :
            this(dependencyDetail)
        {
            VisitedNodes = new HashSet<string>(visitedNodes);
        }

        public DependencyGraphNode(DependencyDetail dependencyDetail, List<DependencyGraphNode> childNodes) :
            this(dependencyDetail)
        {
            ChildNodes = childNodes;
        }

        public DependencyGraphNode(DependencyDetail dependencyDetail, HashSet<string> visitedNodes, List<DependencyGraphNode> childNodes) :
            this(dependencyDetail, visitedNodes)
        {
            ChildNodes = childNodes;
        }

        public HashSet<string> VisitedNodes { get; set; }

        public DependencyDetail DependencyDetail { get; set; }

        public List<DependencyGraphNode> ChildNodes { get; set; }
    }
}
