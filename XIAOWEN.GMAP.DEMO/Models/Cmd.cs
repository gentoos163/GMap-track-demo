﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace XIAOWEN.GMAP.DEMO.Models
{
    public class Cmd
    {
        public ICommand AddMarkerCommand { get; set; }
        public ICommand ClearAllCommand { get; set; }
        public ICommand ActiveTrackCommand { get; set; }
    }
}
