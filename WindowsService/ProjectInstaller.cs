﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Passaredo.Integracao
{
    [RunInstaller(true)]
    public partial class PassaredoIntegracaoInstaller : System.Configuration.Install.Installer
    {
        public PassaredoIntegracaoInstaller()
        {
            InitializeComponent();
        }
    }
}
