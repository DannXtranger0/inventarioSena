﻿#pragma checksum "..\..\..\..\Views\Editar_producto.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51137F44379116987653DE9022D8CBE1559C85AB"
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
    /// Editar_producto
    /// </summary>
    public partial class Editar_producto : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 144 "..\..\..\..\Views\Editar_producto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox persona_encargada;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\Views\Editar_producto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codigo_txt;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Views\Editar_producto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox categoria;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\Views\Editar_producto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox estado;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\Views\Editar_producto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_cantidad;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\Views\Editar_producto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_nombre;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\Views\Editar_producto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\Views\Editar_producto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add_Copiar;
        
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
            System.Uri resourceLocater = new System.Uri("/inventario;component/views/editar_producto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Editar_producto.xaml"
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
            this.persona_encargada = ((System.Windows.Controls.ComboBox)(target));
            
            #line 144 "..\..\..\..\Views\Editar_producto.xaml"
            this.persona_encargada.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.persona_encargada_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.codigo_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 145 "..\..\..\..\Views\Editar_producto.xaml"
            this.codigo_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.codigo_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.categoria = ((System.Windows.Controls.ComboBox)(target));
            
            #line 146 "..\..\..\..\Views\Editar_producto.xaml"
            this.categoria.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.categoria_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.estado = ((System.Windows.Controls.ComboBox)(target));
            
            #line 147 "..\..\..\..\Views\Editar_producto.xaml"
            this.estado.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.estado_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txt_cantidad = ((System.Windows.Controls.TextBox)(target));
            
            #line 148 "..\..\..\..\Views\Editar_producto.xaml"
            this.txt_cantidad.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_cantidad_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_nombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 149 "..\..\..\..\Views\Editar_producto.xaml"
            this.txt_nombre.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_nombre_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\..\..\Views\Editar_producto.xaml"
            this.btn_add.Click += new System.Windows.RoutedEventHandler(this.btn_add_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_add_Copiar = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\..\..\Views\Editar_producto.xaml"
            this.btn_add_Copiar.Click += new System.Windows.RoutedEventHandler(this.btn_add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
