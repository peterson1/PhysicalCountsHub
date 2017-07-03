using NullGuard;
using PhysicalCountsHub.Client.WPF.BarcodeScanningUI;
using PhysicalCountsHub.Common.API;
using Repo2.Core.ns11.DataStructures;
using Repo2.Core.ns11.InputCommands;
using Repo2.Core.ns11.Randomizers;
using Repo2.SDK.WPF45.InputCommands;
using System;
using System.Collections.Generic;

namespace PhysicalCountsHub.Client.WPF.CountConsolidationUI
{
    public class DesignTimeDataVM
    {
        private FakeFactory _fke = new FakeFactory();


        public DesignTimeDataVM()
        {
            CountsTally.Swap(CreateSampleItemCounts());
            InventoryArea = Common.API.InventoryArea.Unknown;
            RefreshCmd    = R2Command.Relay(() => { });
            SubmitCmd     = R2Command.Relay(() => { });
        }


        public Observables<ItemCountRow> CountsTally { get; } = new Observables<ItemCountRow>();

        public InventoryArea?  InventoryArea  { get; set; }
        public IR2Command      RefreshCmd     { get; }
        public IR2Command      SubmitCmd      { get; }

        [AllowNull]
        public string          LoginName      { get; set; }

        [AllowNull]
        public string          Remarks        { get; set; }




        private IEnumerable<ItemCountRow> CreateSampleItemCounts()
        {
            var list = new List<ItemCountRow>();

            list.Add(SampleRow("WHATTATOPSMNGOGRHM 35GX10"));
            list.Add(SampleRow("NESCAFE DECAFRESEAL9"));
            list.Add(SampleRow("NESCAFE DECAFRESEAL4"));
            list.Add(SampleRow("BEARBRAND CHOCO 150GX40"));
            list.Add(SampleRow("BEARBRANDCHCOSWK29GX128"));
            list.Add(SampleRow("BEARBRAND MILK 1.6KGX10"));
            list.Add(SampleRow("KITKAT CHNKYBNDLS 11"));
            list.Add(SampleRow("MILO NUTRI UP 390GX1"));
            list.Add(SampleRow("MILO NUTRI UP 24GX14"));
            list.Add(SampleRow("NESTOKID FOUR 700GX10"));
            list.Add(SampleRow("NESFRUTA GUYABANO 25GX144"));
            list.Add(SampleRow("KITKAT2F17GX6SFRBENC"));
            list.Add(SampleRow("COFFEEMATE STAND UP POUCH"));
            list.Add(SampleRow("COFFEEMATE ORIG 170GX60"));
            list.Add(SampleRow("COFFEEMATE 290GX40"));
            list.Add(SampleRow("NESCFE3IN1CRMYTPCK50GX120"));
            list.Add(SampleRow("BB CHOCO 28G 9+1 X 24"));
            list.Add(SampleRow("BB MILK 28G 9+1 X 24"));
            list.Add(SampleRow("KITKAT 3+1 2F 4GX17G"));
            list.Add(SampleRow("NESCFEBRWNCRMYTPCK40"));
            list.Add(SampleRow("NESCAFE COCOMOCHA30GX240"));
            list.Add(SampleRow("NESCAFE COCOMOCHA 30GX240"));
            list.Add(SampleRow("NESCAFE BERRYMOCHA30GX240"));
            list.Add(SampleRow("NESTEA KIWILMNBLND25GX144"));
            list.Add(SampleRow("BB PWD MILK 33GX13+1X8"));
            list.Add(SampleRow("NESCAFE BERRYMOCHA30"));
            list.Add(SampleRow("NESC DECAF 30(80G+80G) FR"));
            list.Add(SampleRow("NESCFE3IN1ORIG20GX36X12"));
            list.Add(SampleRow("NSCAFE3IN1BRWNCRMY23GX240"));
            list.Add(SampleRow("NESCFE BLEND&BREW 20GX528"));
            list.Add(SampleRow("NESCFE BLEND&BREW 20GX432"));
            list.Add(SampleRow("MILO RTD 180MLX2SX16"));
            list.Add(SampleRow("CHUCKIE180MLX8SX4FRL"));
            list.Add(SampleRow("NESCFE B&B S.ROAST21"));
            list.Add(SampleRow("NESCFE B&B ESPRSSO20"));
            list.Add(SampleRow("MAGGI MAGIC SARAP8GX24X36"));
            list.Add(SampleRow("NESCFE B&B ESPRSSO20"));
            list.Add(SampleRow("MAGGI SNGNG PAPPLE45"));
            list.Add(SampleRow("MAGGI SNGNG GRNMNGO2"));
            list.Add(SampleRow("NESCAFE RTD BPCK4S20"));
            list.Add(SampleRow("NESTOKID FOUR 600GX3"));
            list.Add(SampleRow("BEARBRANDADULTPLUS33"));
            list.Add(SampleRow("NIDO FORTIGROW 160GX48"));
            list.Add(SampleRow("NESTLEAPCREAM+MMS250X24"));
            list.Add(SampleRow("NIDO JUNIOR 1-3 700G"));
            list.Add(SampleRow("MILORTD180MLX4SX8FRC"));
            list.Add(SampleRow("MAGGI SINGNG SP PCK7"));
            list.Add(SampleRow("BEARBRAND POWDER 99GX120"));
            list.Add(SampleRow("NESC 3 IN1CREAMY WHTE TWI"));
            list.Add(SampleRow("NESTEA STRWBRY KIWI BLND"));
            list.Add(SampleRow("NESTEA PEACH LEMON BLND I"));
            list.Add(SampleRow("NESFRUTA MANGOSTEEN 22GX1"));
            list.Add(SampleRow("NESFRUTA BUKO 22GX144"));
            list.Add(SampleRow("NESFRUTA DLNDN25GX24(5+1)"));
            list.Add(SampleRow("NESCAFE 3IN1 ORIG TWIN PA"));
            list.Add(SampleRow("NESCF MOCHA (6X30G+6X30G)"));
            list.Add(SampleRow("ESPERMA #6 WHITE 20S"));
            list.Add(SampleRow("LIWNG CNDLE FILLR 3D"));
            list.Add(SampleRow("LWNG CNDLE FLLER 3DY"));
            list.Add(SampleRow("L PLAIN PILLAR YELLO"));
            list.Add(SampleRow("LIWANAG PILLAR #S31 "));
            list.Add(SampleRow("LIWANAG PLAIN PILLAR"));
            list.Add(SampleRow("LIWANAG  PILLAR WHTE"));
            list.Add(SampleRow("LIWANAG PILLAR YELLO"));
            list.Add(SampleRow("LIWANAG  PILLARWHTE#"));
            list.Add(SampleRow("LIWANAG PLAIN PILLAR"));
            list.Add(SampleRow("LIWANAG CANDLE #149 "));
            list.Add(SampleRow("LIWNAG PILLAR YELLOW"));
            list.Add(SampleRow("LIWNAG #S150 PILLAR "));
            list.Add(SampleRow("LIWNAG  PILLAR#S150Y"));
            list.Add(SampleRow("LIWANAG PLAIN PILLAR"));
            list.Add(SampleRow("LIWNAG PILLAR #S151 "));
            list.Add(SampleRow("LIWNAG PILLAR YELLOW"));
            list.Add(SampleRow("LIWNAG HEXAGON SMALL"));
            list.Add(SampleRow("L HEXAGON SMALL#168Y"));
            list.Add(SampleRow("L LOURDES #S187 WHIT"));
            list.Add(SampleRow("L LOURDES #S187 YELL"));
            list.Add(SampleRow("WILKINS DELIGHT APPLE 425"));
            list.Add(SampleRow("L PLAIN PILLAR WHITE"));
            list.Add(SampleRow("CHOC NUT MILK CHOCOL"));
            list.Add(SampleRow("PANDA COINS MLK CHO20SX20"));
            list.Add(SampleRow("VECTOR PLS ELHDL 1UP"));
            list.Add(SampleRow("YAKULT 5S PACK"));
            list.Add(SampleRow("TULLIP JAMONILLA LUN"));
            list.Add(SampleRow("TULLIP JAMONILLA LUN"));
            list.Add(SampleRow("CAMPBELL CRMMSHROM28"));
            list.Add(SampleRow("CAMPBELL CRMMSHROM28"));
            list.Add(SampleRow("DOVE CREAM BAR PINK 100G"));
            list.Add(SampleRow("CHAMPION PITTED DRIE"));
            list.Add(SampleRow("DAK CHOPPED HAM 454G"));
            list.Add(SampleRow("SWISS MISS CHOCO MIL"));
            list.Add(SampleRow("SWISS MISS MARSHMALL"));
            list.Add(SampleRow("SWISS MISS CHOCO MIL"));
            list.Add(SampleRow("SWISS MISS MARSHMALL"));

            return list;
        }


        private ItemCountRow SampleRow(string desc)
        {
            var qty = _fke.Int(1, 20);
            return new ItemCountRow
            {
                TimeScanned = DateTime.Now.AddSeconds(qty),
                Quantity = qty,
                Description = desc,
                DeleteCmd = R2Command.Relay(() => { })
            };
        }
    }
}
