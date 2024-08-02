﻿using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TacgiaBLL
    {
        TacgiaRepository repos;
        public TacgiaBLL()
        {
            repos = new TacgiaRepository();
        }
        public List<TacGium> GetTacGia()
        {
            return repos.GetAll();
        }
        public string ThemTG(TacGium tg)
        {
            if (repos.Add_Obj(tg))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaTG(TacGium tg)
        {
            
            if (repos.Update_Obj(tg))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}