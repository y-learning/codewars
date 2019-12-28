using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Kata
    {
        public static string ReverseWords( string text )
        {
            return string.Join( " ", text.Split( ' ' ).Reverse() );
        }

        public static int DuplicateCount( string str )
        {
            str = str.ToLower();
            var distinctChars = new HashSet<char>();
            var strLength = str.Length;

            for ( var i = 0; i < strLength; i++ )
            for ( var j = i + 1; j < strLength; j++ )
            {
                var c = str[i];
                if ( c == str[j] )
                    distinctChars.Add( c );
            }

            return distinctChars.Count;
        }

        public static string MakeComplement( string dna )
        {
            var pairs = new[] { new[] { 'T', 'A' }, new[] { 'G', 'C' } };
            var complementarySide = string.Empty;

            foreach ( var symbol in dna )
            foreach ( var complements in pairs )
                if ( symbol == complements[0] )
                    complementarySide += complements[1];
                else if ( symbol == complements[1] )
                    complementarySide += complements[0];

            return complementarySide;
        }

        public static string CreatePhoneNumber( params int[] numbers )
        {
            return long.Parse( string.Concat( numbers ) ).ToString( "(000) 000-0000" );
        }

        public static bool IsIsogram( string str )
        {
            return str.ToLower().ToList().Distinct().Count() == str.Length;
        }

        public static bool IsSquare( int n )
        {
            for ( var i = 0; i <= n / 2 + 1; i++ )
                if ( n == i * i ) return true;
                else if ( n < i * i ) return false;

            return false;
        }

        public static string AddBinary( int n, int m )
        {
            return Convert.ToString( n + m, 2 );
        }

        public static string Order( string words )
        {
            var splits = words.Split( ' ' );
            var sorted = new string[splits.Length];

            foreach ( var word in splits )
            foreach ( var c in word )
                if ( int.TryParse( c.ToString(), out var n ) )
                    sorted[n - 1] = word;

            return string.Join( ' ', sorted );
        }

        public static char FindMissingLetter( char[] array )
        {
            for ( var i = 0; i < array.Length - 1; i++ )
                if ( array[i + 1] - array[i] > 1 )
                    return (char) ( array[i] + 1 );

            return ' ';
        }

        public static int FindOddInt( params int[] seq )
        {
            var seqLength = seq.Length;
            for ( var i = 0; i < seqLength; i++ )
            {
                var count = 0;
                for ( var j = 0; j < seqLength; j++ )
                    if ( seq[i] == seq[j] )
                        count++;

                if ( count % 2 != 0 )
                    return seq[i];
            }

            return -1;
        }

        public static string PigIt( string str )
        {
            return str.Split( ' ' ).Aggregate( string.Empty,
                    ( current, word ) =>
                        current + ( !word.All( char.IsLetterOrDigit ) ? word : $"{word.Substring( 1 )}{word[0]}ay " ) )
                .TrimEnd();
        }

        public static string CamelCase( string str )
        {
            return str?.Split( ' ' ).Where( word => !string.IsNullOrEmpty( word ) ).Aggregate( string.Empty,
                ( camelCase, word ) => $"{camelCase}{char.ToUpper( word[0] )}{word.Substring( 1 )}" );
        }

        public static string Rot13( string input )
        {
            var rot13 = string.Empty;
            foreach ( var c in input )
            {
                var character = c;
                if ( char.IsLetter( c ) )
                    for ( var i = 0; i < 13; i++ )
                        if ( char.IsLower( c ) && character < 'z' || char.IsUpper( c ) && character < 'Z' ) character++;
                        else character = (char) ( character - 25 );

                rot13 += character;
            }

            return rot13;
        }
    }
}