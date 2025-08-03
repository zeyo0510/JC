﻿using System;
using System.Collections.Generic;
/************************************************/
namespace JC.Lib.CS.Development
{
  partial class DotnetFramework
  {
    private static List<DotnetFramework> _Items = null;
    /************************************************/
    public static DotnetFramework[] Items
    {
      get
      {
        if (DotnetFramework._Items == null)
        {
          DotnetFramework._Items = new List<DotnetFramework>();
          /************************************************/
          DotnetFramework._Items.Add(DotnetFramework.V20      );
          DotnetFramework._Items.Add(DotnetFramework.V30      );
          DotnetFramework._Items.Add(DotnetFramework.V35      );
          DotnetFramework._Items.Add(DotnetFramework.V40Client);
          DotnetFramework._Items.Add(DotnetFramework.V40Full  );
          DotnetFramework._Items.Add(DotnetFramework.V4xClient);
          DotnetFramework._Items.Add(DotnetFramework.V4xFull  );
        }
        /************************************************/
        return DotnetFramework._Items.ToArray();
      }
    }
  }
}