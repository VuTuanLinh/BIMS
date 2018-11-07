﻿using BIMS.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIMS.Model
{
    /**
    * A Construcion object what contains infomation relate to the construction.
    * 
    *
    * @author  LinhVT
    * @version 1.0
    * @since   2018/11/6
    */
    class Construcion
    {
        private int      _Construction_Id;
        private string   _Construction_No;
        private string   _Name;
        private Position _Position;

        public Construcion()
        {

        }
        [Required, AutoIncrement, PrimaryKey, SqlParameter("construcion_id")]
        public　int Construction_Id
        {
            get
            {
                return _Construction_Id;
            }
            set
            {
                _Construction_Id = value;
            }
        }
        [Required, Unique, ExcelColumn("E"), SqlParameter("construcion_no")]
        public string Construction_No
        {
            get
            {
                return _Construction_No;
            }
            set
            {
                _Construction_No = value;
            }
        }
        [Required, ExcelColumn("F"), SqlParameter("name")]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        [Required, ExcelColumn("G"), ForeignKey("position", "name[F]=>position_id"), SqlParameter("position_id")]
        public Position Position {
            get
            {
                return _Position;
            }
            set
            {
                _Position = value;
            }
        }

    }
}
