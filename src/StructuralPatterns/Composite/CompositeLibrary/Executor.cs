﻿using CompositeLibrary.FileSystemExample;
using CompositeLibrary.GiftExample;
using CompositeLibrary.ShareholdersExample;
using DesignPatternsLibrary.PatternExecutors;

namespace CompositeLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Composite - Composite Library - Structural Pattern";

        public override void Execute()
        {
            GiftExecutor.Execute();
            FileSystemExecutor.Execute();
            ShareholdersExecutor.Execute();
        }
    }
}
