﻿#pragma checksum "..\..\..\..\Views\Registro_prestamo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1778368353004B47A482DDB217AA10953E7D311A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
    /// Registro_prestamo
    /// </summary>
    public partial class Registro_prestamo : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 160 "..\..\..\..\Views\Registro_prestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox documento_persona;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\..\Views\Registro_prestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codigo_serial_txt;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\Views\Registro_prestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fecha_pres;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\Views\Registro_prestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker fecha_devolucion;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\..\Views\Registro_prestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdocuemnto_fun;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\..\Views\Registro_prestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button validar_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/inventario;component/views/registro_prestamo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Registro_prestamo.xaml"
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
            this.documento_persona = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.codigo_serial_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.fecha_pres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.fecha_devolucion = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.txtdocuemnto_fun = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.validar_btn = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\..\..\Views\Registro_prestamo.xaml"
            this.validar_btn.Click += new System.Windows.RoutedEventHandler(this.validar_btn_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 170 "..\..\..\..\Views\Registro_prestamo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_registro_persona);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

