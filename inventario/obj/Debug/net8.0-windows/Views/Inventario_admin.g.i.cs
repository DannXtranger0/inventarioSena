﻿#pragma checksum "..\..\..\..\Views\Inventario_admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3462AF7F52418DB7F57373274AC97FC268E8E726"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using inventario.Views;


namespace inventario.Views {
    
    
    /// <summary>
    /// Inventario_admin
    /// </summary>
    public partial class Inventario_admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 279 "..\..\..\..\Views\Inventario_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame_principal;
        
        #line default
        #line hidden
        
        
        #line 282 "..\..\..\..\Views\Inventario_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid menu_lateral;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/inventario;component/views/inventario_admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Inventario_admin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.frame_principal = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.menu_lateral = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 285 "..\..\..\..\Views\Inventario_admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_todos);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 291 "..\..\..\..\Views\Inventario_admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_informatica);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 297 "..\..\..\..\Views\Inventario_admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_agricultura);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 303 "..\..\..\..\Views\Inventario_admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_herramientas);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

