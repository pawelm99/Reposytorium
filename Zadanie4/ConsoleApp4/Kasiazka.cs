using System;

namespace ConsoleApp4
{
    public class Kasiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        private int _numerRegalu;
        private int _numerPolki;
        private int _nrMiejNaPolce;

        public Kasiazka(int numerRegalu, int numerPolki, int nrMiejNaPolce, string tytul, string autor)
        {
            _numerRegalu = numerRegalu;
            _numerPolki = numerPolki;
            _nrMiejNaPolce = nrMiejNaPolce;
            Tytul = tytul;
            Autor = autor;
        }

        public override string ToString()
        {
            return $"Regał: {_numerRegalu}, Półka: {_numerPolki}, Miejsce na półce:: {_nrMiejNaPolce}, {nameof(Tytul)}: {Tytul}, {nameof(Autor)}: {Autor}";
        }
    }
}