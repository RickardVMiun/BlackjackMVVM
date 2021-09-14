using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Blackjack_MVVM.Converters
{
    public class EnumToSymbolConverter : GenericCard /*: IValueConverter*/
    {
        public char HeartSymbol { get; set; } = '♥';
        public char ClubsSymbol { get; set; } = '♣';
        public char SpadesSymbol { get; set; } = '♠';
        public char DiamondsSymbol { get; set; } = '♦';

        GenericCard card = new GenericCard();

        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    if ((char) value == 0 )
        //    {
        //        return HeartSymbol;
        //    }
        //}

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    throw new NotImplementedException();
        //}
        //public char ConvertEnum()
        //{
        //    if (card.CardSuit == "Hjärter")
        //    {
        //        return HeartSymbol;
        //    }
        //    else
        //    {
        //        return SpadesSymbol;
        //    }
        //}

        //public EnumToSymbolConverter()
        //{

        //    ConvertEnum();

        //}
    }
}
