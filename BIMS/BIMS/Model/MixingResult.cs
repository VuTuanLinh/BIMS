﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIMS.Attributes;

namespace BIMS.Model
{
    /** 
    * @author  LinhVT
    * @version 1.0
    * @since   2018/11/7
    */
    class MixingResult
    {
        private int _MixingResultId;
        private double _Cement_Amount;
        private double _Archived_Strength;
        private double _Water_Content_Ratio;
        private double _Wet_Density;
        private Cement _Cement;
        private TestingSample _TestingSample;

        [PrimaryKey, AutoIncrement]
        public int MixingResultId
        {
            get
            {
                return _MixingResultId;
            }
            set
            {
                _MixingResultId = value;
            }
        }
        [Required, ExcelColumn("U")]
        public double Cement_Amount
        {
            get
            {
                return _Cement_Amount;
            }
            set
            {
                _Cement_Amount = value;
            }
        }
        [Required, ExcelColumn("V")]
        public double Archived_Strength
        {
            get
            {
                return _Archived_Strength;
            }
            set
            {
                _Archived_Strength = value;
            }
        }
        [Required, ExcelColumn("T")]
        public double Water_Content_Ratio
        {
            get
            {
                return _Water_Content_Ratio;
            }
            set
            {
                _Water_Content_Ratio = value;
            }
        }
        [Required]
        public double Wet_Density
        {
            get
            {
                return _Wet_Density;
            }
            set
            {
                _Wet_Density = value;
            }
        }
        [Required, ExcelColumn("I"), ForeignKey("cement", "cement_id", "name")]
        public Cement Cement
        {
            get
            {
                return _Cement;
            }
            set
            {
                _Cement = value;
            }

        }
        [Required, ExcelColumn("G"), ForeignKey("position", "position_id", "name")]
        public TestingSample TestingSample
        {
            get
            {
                return _TestingSample;
            }
            set
            {
                _TestingSample = value;
            }

        }



    }
}
