using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=391641

namespace phoneAppForLeaya
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные события, описывающие, каким образом была достигнута эта страница.
        /// Этот параметр обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Подготовьте здесь страницу для отображения.

            // TODO: Если приложение содержит несколько страниц, обеспечьте
            // обработку нажатия аппаратной кнопки "Назад", выполнив регистрацию на
            // событие Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Если вы используете NavigationHelper, предоставляемый некоторыми шаблонами,
            // данное событие обрабатывается для вас.
        }

        private void submiteComponents_Click(object sender, RoutedEventArgs e)
        {
            
            components component = new components();
            component.Node = Convert.ToInt32(NulltoZero(NodesValue.Text));
            component.resistor = Convert.ToInt32(NulltoZero(ResistorValue.Text));
            component.capacitor = Convert.ToInt32(NulltoZero(CapacitorValue.Text));
            component.Iductor = Convert.ToInt32(NulltoZero(InductorValue.Text));
            component.outputpositive = Convert.ToInt32(NulltoZero(outputPositiveValue.Text));
            component.outputnegative = Convert.ToInt32(NulltoZero(outputNegativeValue.Text));


            if (component.resistor != 0)
                Frame.Navigate(typeof(resistor) , component);
            else if (component.capacitor != 0)
                Frame.Navigate(typeof(capacitor), component);
            else if (component.Iductor != 0)
                Frame.Navigate(typeof(inductor), component);
            else
                Frame.Navigate(typeof(result), component);

        }
        private string NulltoZero(string value)
        {
            if (value == "") value = "0";
            return value;
        }

        private void ResistorValue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void InductorValue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
