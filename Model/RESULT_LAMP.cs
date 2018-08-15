using System;
using System.Data;

namespace Model
{
    public class RESULT_LAMP
    {

        private int m_ID;
        private string m_DGZWDJCCS;
        private string m_DGZNDJCCS;
        private string m_DGYNDJCCS;
        private string m_DGYWDJCCS;
        private string m_JCLSH;
        private string m_ZWDYGGQ;
        private string m_ZWDYGGQ_PD;
        private string m_ZWDYGCZPYL;
        private string m_ZWDYGSPPYL;
        private string m_ZWDYGDG;
        private string m_ZWDYGCZPY;
        private string m_ZWDYGCZPY_PD;
        private string m_ZWDYGSPPY;
        private string m_ZWDYGSPPY_PD;
        private string m_ZWDJGCZPYL;
        private string m_ZWDJGSPPYL;
        private string m_ZWDJGDG;
        private string m_ZWDJGCZPY;
        private string m_ZWDJGCZPY_PD;
        private string m_ZWDJGSPPY;
        private string m_ZWDJGSPPY_PD;
        private string m_ZWDZ_PD;
        private string m_ZNDYGGQ;
        private string m_ZNDYGGQ_PD;
        private string m_ZNDYGCZPYL;
        private string m_ZNDYGSPPYL;
        private string m_ZNDYGDG;
        private string m_ZNDYGCZPY;
        private string m_ZNDYGCZPY_PD;
        private string m_ZNDYGSPPY;
        private string m_ZNDYGSPPY_PD;
        private string m_ZNDJGCZPYL;
        private string m_ZNDJGSPPYL;
        private string m_ZNDJGDG;
        private string m_ZNDJGCZPY;
        private string m_ZNDJGCZPY_PD;
        private string m_ZNDJGSPPY;
        private string m_ZNDJGSPPY_PD;
        private string m_ZNDZ_PD;
        private string m_YNDYGGQ;
        private string m_YNDYGGQ_PD;
        private string m_YNDYGCZPYL;
        private string m_YNDYGSPPYL;
        private string m_YNDYGDG;
        private string m_YNDYGCZPY;
        private string m_YNDYGCZPY_PD;
        private string m_YNDYGSPPY;
        private string m_YNDYGSPPY_PD;
        private string m_YNDJGCZPYL;
        private string m_YNDJGSPPYL;
        private string m_YNDJGDG;
        private string m_YNDJGCZPY;
        private string m_YNDJGCZPY_PD;
        private string m_YNDJGSPPY;
        private string m_YNDJGSPPY_PD;
        private string m_YNDZ_PD;
        private string m_YWDYGGQ;
        private string m_YWDYGGQ_PD;
        private string m_YWDYGCZPYL;
        private string m_YWDYGSPPYL;
        private string m_YWDYGDG;
        private string m_YWDYGCZPY;
        private string m_YWDYGCZPY_PD;
        private string m_YWDYGSPPY;
        private string m_YWDYGSPPY_PD;
        private string m_YWDJGCZPYL;
        private string m_YWDJGSPPYL;
        private string m_YWDJGDG;
        private string m_YWDJGCZPY;
        private string m_YWDJGCZPY_PD;
        private string m_YWDJGSPPY;
        private string m_YWDJGSPPY_PD;
        private string m_YWDZ_PD;
        private string m_DGZGQ;
        private string m_DGZGQ_PD;
        private string m_DGGQXZ;
        private string m_YGCZPYXZXX;
        private string m_YGCZPYXZSX;
        private string m_YGZDZPXZ;
        private string m_YGZDYPXZ;
        private string m_YGYDZPXZ;
        private string m_YGYDYPXZ;
        private string m_JGCZPYXZXX;
        private string m_JGCZPYXZSX;
        private string m_JGZDZPXZ;
        private string m_JGZDYPXZ;
        private string m_JGYDZPXZ;
        private string m_JGYDYPXZ;
        private string m_ZGQXZ;
        private string m_DGZ_PD;
        private string m_KSSJ;
        private string m_JSSJ;
        private string m_BIG1000JGCZPYXZXX;
        private string m_BIG1000JGCZPYXZSX;
        private string m_ZWDDGGQXZ;
        private string m_ZWDYGCZPYXZSX;
        private string m_ZWDYGCZPYXZXX;
        private string m_ZWDJGCZPYXZSX;
        private string m_ZWDJGCZPYXZXX;
        private string m_ZWDYGZDYPXZ;
        private string m_ZWDYGZDZPXZ;
        private string m_ZWDYGYDYPXZ;
        private string m_ZWDYGYDZPXZ;
        private string m_ZWDJGZDYPXZ;
        private string m_ZWDJGZDZPXZ;
        private string m_ZWDJGYDYPXZ;
        private string m_ZWDJGYDZPXZ;
        private string m_ZNDDGGQXZ;
        private string m_ZNDYGCZPYXZSX;
        private string m_ZNDYGCZPYXZXX;
        private string m_ZNDJGCZPYXZSX;
        private string m_ZNDJGCZPYXZXX;
        private string m_ZNDYGZDYPXZ;
        private string m_ZNDYGZDZPXZ;
        private string m_ZNDYGYDYPXZ;
        private string m_ZNDYGYDZPXZ;
        private string m_ZNDJGZDYPXZ;
        private string m_ZNDJGZDZPXZ;
        private string m_ZNDJGYDYPXZ;
        private string m_ZNDJGYDZPXZ;
        private string m_YNDDGGQXZ;
        private string m_YNDYGCZPYXZSX;
        private string m_YNDYGCZPYXZXX;
        private string m_YNDJGCZPYXZSX;
        private string m_YNDJGCZPYXZXX;
        private string m_YNDYGZDYPXZ;
        private string m_YNDYGZDZPXZ;
        private string m_YNDYGYDYPXZ;
        private string m_YNDYGYDZPXZ;
        private string m_YNDJGZDYPXZ;
        private string m_YNDJGZDZPXZ;
        private string m_YNDJGYDYPXZ;
        private string m_YNDJGYDZPXZ;
        private string m_YWDDGGQXZ;
        private string m_YWDYGCZPYXZSX;
        private string m_YWDYGCZPYXZXX;
        private string m_YWDJGCZPYXZSX;
        private string m_YWDJGCZPYXZXX;
        private string m_YWDYGZDYPXZ;
        private string m_YWDYGZDZPXZ;
        private string m_YWDYGYDYPXZ;
        private string m_YWDYGYDZPXZ;
        private string m_YWDJGZDYPXZ;
        private string m_YWDJGZDZPXZ;
        private string m_YWDJGYDYPXZ;
        private string m_YWDJGYDZPXZ;

        /// <summary>
        /// 获取或设置ID
        /// </summary>
        public int ID
        {
            get
            {
                return m_ID;
            }
            set
            {
                m_ID = value;
            }
        }

        /// <summary>
        /// 获取或设置DGZWDJCCS
        /// </summary>
        public string DGZWDJCCS
        {
            get
            {
                return m_DGZWDJCCS;
            }
            set
            {
                m_DGZWDJCCS = value;
            }
        }

        /// <summary>
        /// 获取或设置DGZNDJCCS
        /// </summary>
        public string DGZNDJCCS
        {
            get
            {
                return m_DGZNDJCCS;
            }
            set
            {
                m_DGZNDJCCS = value;
            }
        }

        /// <summary>
        /// 获取或设置DGYNDJCCS
        /// </summary>
        public string DGYNDJCCS
        {
            get
            {
                return m_DGYNDJCCS;
            }
            set
            {
                m_DGYNDJCCS = value;
            }
        }

        /// <summary>
        /// 获取或设置DGYWDJCCS
        /// </summary>
        public string DGYWDJCCS
        {
            get
            {
                return m_DGYWDJCCS;
            }
            set
            {
                m_DGYWDJCCS = value;
            }
        }

        /// <summary>
        /// 获取或设置JCLSH
        /// </summary>
        public string JCLSH
        {
            get
            {
                return m_JCLSH;
            }
            set
            {
                m_JCLSH = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGGQ
        /// </summary>
        public string ZWDYGGQ
        {
            get
            {
                return m_ZWDYGGQ;
            }
            set
            {
                m_ZWDYGGQ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGGQ_PD
        /// </summary>
        public string ZWDYGGQ_PD
        {
            get
            {
                return m_ZWDYGGQ_PD;
            }
            set
            {
                m_ZWDYGGQ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGCZPYL
        /// </summary>
        public string ZWDYGCZPYL
        {
            get
            {
                return m_ZWDYGCZPYL;
            }
            set
            {
                m_ZWDYGCZPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGSPPYL
        /// </summary>
        public string ZWDYGSPPYL
        {
            get
            {
                return m_ZWDYGSPPYL;
            }
            set
            {
                m_ZWDYGSPPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGDG
        /// </summary>
        public string ZWDYGDG
        {
            get
            {
                return m_ZWDYGDG;
            }
            set
            {
                m_ZWDYGDG = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGCZPY
        /// </summary>
        public string ZWDYGCZPY
        {
            get
            {
                return m_ZWDYGCZPY;
            }
            set
            {
                m_ZWDYGCZPY = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGCZPY_PD
        /// </summary>
        public string ZWDYGCZPY_PD
        {
            get
            {
                return m_ZWDYGCZPY_PD;
            }
            set
            {
                m_ZWDYGCZPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGSPPY
        /// </summary>
        public string ZWDYGSPPY
        {
            get
            {
                return m_ZWDYGSPPY;
            }
            set
            {
                m_ZWDYGSPPY = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGSPPY_PD
        /// </summary>
        public string ZWDYGSPPY_PD
        {
            get
            {
                return m_ZWDYGSPPY_PD;
            }
            set
            {
                m_ZWDYGSPPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGCZPYL
        /// </summary>
        public string ZWDJGCZPYL
        {
            get
            {
                return m_ZWDJGCZPYL;
            }
            set
            {
                m_ZWDJGCZPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGSPPYL
        /// </summary>
        public string ZWDJGSPPYL
        {
            get
            {
                return m_ZWDJGSPPYL;
            }
            set
            {
                m_ZWDJGSPPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGDG
        /// </summary>
        public string ZWDJGDG
        {
            get
            {
                return m_ZWDJGDG;
            }
            set
            {
                m_ZWDJGDG = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGCZPY
        /// </summary>
        public string ZWDJGCZPY
        {
            get
            {
                return m_ZWDJGCZPY;
            }
            set
            {
                m_ZWDJGCZPY = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGCZPY_PD
        /// </summary>
        public string ZWDJGCZPY_PD
        {
            get
            {
                return m_ZWDJGCZPY_PD;
            }
            set
            {
                m_ZWDJGCZPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGSPPY
        /// </summary>
        public string ZWDJGSPPY
        {
            get
            {
                return m_ZWDJGSPPY;
            }
            set
            {
                m_ZWDJGSPPY = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGSPPY_PD
        /// </summary>
        public string ZWDJGSPPY_PD
        {
            get
            {
                return m_ZWDJGSPPY_PD;
            }
            set
            {
                m_ZWDJGSPPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDZ_PD
        /// </summary>
        public string ZWDZ_PD
        {
            get
            {
                return m_ZWDZ_PD;
            }
            set
            {
                m_ZWDZ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGGQ
        /// </summary>
        public string ZNDYGGQ
        {
            get
            {
                return m_ZNDYGGQ;
            }
            set
            {
                m_ZNDYGGQ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGGQ_PD
        /// </summary>
        public string ZNDYGGQ_PD
        {
            get
            {
                return m_ZNDYGGQ_PD;
            }
            set
            {
                m_ZNDYGGQ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGCZPYL
        /// </summary>
        public string ZNDYGCZPYL
        {
            get
            {
                return m_ZNDYGCZPYL;
            }
            set
            {
                m_ZNDYGCZPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGSPPYL
        /// </summary>
        public string ZNDYGSPPYL
        {
            get
            {
                return m_ZNDYGSPPYL;
            }
            set
            {
                m_ZNDYGSPPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGDG
        /// </summary>
        public string ZNDYGDG
        {
            get
            {
                return m_ZNDYGDG;
            }
            set
            {
                m_ZNDYGDG = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGCZPY
        /// </summary>
        public string ZNDYGCZPY
        {
            get
            {
                return m_ZNDYGCZPY;
            }
            set
            {
                m_ZNDYGCZPY = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGCZPY_PD
        /// </summary>
        public string ZNDYGCZPY_PD
        {
            get
            {
                return m_ZNDYGCZPY_PD;
            }
            set
            {
                m_ZNDYGCZPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGSPPY
        /// </summary>
        public string ZNDYGSPPY
        {
            get
            {
                return m_ZNDYGSPPY;
            }
            set
            {
                m_ZNDYGSPPY = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGSPPY_PD
        /// </summary>
        public string ZNDYGSPPY_PD
        {
            get
            {
                return m_ZNDYGSPPY_PD;
            }
            set
            {
                m_ZNDYGSPPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGCZPYL
        /// </summary>
        public string ZNDJGCZPYL
        {
            get
            {
                return m_ZNDJGCZPYL;
            }
            set
            {
                m_ZNDJGCZPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGSPPYL
        /// </summary>
        public string ZNDJGSPPYL
        {
            get
            {
                return m_ZNDJGSPPYL;
            }
            set
            {
                m_ZNDJGSPPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGDG
        /// </summary>
        public string ZNDJGDG
        {
            get
            {
                return m_ZNDJGDG;
            }
            set
            {
                m_ZNDJGDG = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGCZPY
        /// </summary>
        public string ZNDJGCZPY
        {
            get
            {
                return m_ZNDJGCZPY;
            }
            set
            {
                m_ZNDJGCZPY = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGCZPY_PD
        /// </summary>
        public string ZNDJGCZPY_PD
        {
            get
            {
                return m_ZNDJGCZPY_PD;
            }
            set
            {
                m_ZNDJGCZPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGSPPY
        /// </summary>
        public string ZNDJGSPPY
        {
            get
            {
                return m_ZNDJGSPPY;
            }
            set
            {
                m_ZNDJGSPPY = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGSPPY_PD
        /// </summary>
        public string ZNDJGSPPY_PD
        {
            get
            {
                return m_ZNDJGSPPY_PD;
            }
            set
            {
                m_ZNDJGSPPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDZ_PD
        /// </summary>
        public string ZNDZ_PD
        {
            get
            {
                return m_ZNDZ_PD;
            }
            set
            {
                m_ZNDZ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGGQ
        /// </summary>
        public string YNDYGGQ
        {
            get
            {
                return m_YNDYGGQ;
            }
            set
            {
                m_YNDYGGQ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGGQ_PD
        /// </summary>
        public string YNDYGGQ_PD
        {
            get
            {
                return m_YNDYGGQ_PD;
            }
            set
            {
                m_YNDYGGQ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGCZPYL
        /// </summary>
        public string YNDYGCZPYL
        {
            get
            {
                return m_YNDYGCZPYL;
            }
            set
            {
                m_YNDYGCZPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGSPPYL
        /// </summary>
        public string YNDYGSPPYL
        {
            get
            {
                return m_YNDYGSPPYL;
            }
            set
            {
                m_YNDYGSPPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGDG
        /// </summary>
        public string YNDYGDG
        {
            get
            {
                return m_YNDYGDG;
            }
            set
            {
                m_YNDYGDG = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGCZPY
        /// </summary>
        public string YNDYGCZPY
        {
            get
            {
                return m_YNDYGCZPY;
            }
            set
            {
                m_YNDYGCZPY = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGCZPY_PD
        /// </summary>
        public string YNDYGCZPY_PD
        {
            get
            {
                return m_YNDYGCZPY_PD;
            }
            set
            {
                m_YNDYGCZPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGSPPY
        /// </summary>
        public string YNDYGSPPY
        {
            get
            {
                return m_YNDYGSPPY;
            }
            set
            {
                m_YNDYGSPPY = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGSPPY_PD
        /// </summary>
        public string YNDYGSPPY_PD
        {
            get
            {
                return m_YNDYGSPPY_PD;
            }
            set
            {
                m_YNDYGSPPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGCZPYL
        /// </summary>
        public string YNDJGCZPYL
        {
            get
            {
                return m_YNDJGCZPYL;
            }
            set
            {
                m_YNDJGCZPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGSPPYL
        /// </summary>
        public string YNDJGSPPYL
        {
            get
            {
                return m_YNDJGSPPYL;
            }
            set
            {
                m_YNDJGSPPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGDG
        /// </summary>
        public string YNDJGDG
        {
            get
            {
                return m_YNDJGDG;
            }
            set
            {
                m_YNDJGDG = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGCZPY
        /// </summary>
        public string YNDJGCZPY
        {
            get
            {
                return m_YNDJGCZPY;
            }
            set
            {
                m_YNDJGCZPY = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGCZPY_PD
        /// </summary>
        public string YNDJGCZPY_PD
        {
            get
            {
                return m_YNDJGCZPY_PD;
            }
            set
            {
                m_YNDJGCZPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGSPPY
        /// </summary>
        public string YNDJGSPPY
        {
            get
            {
                return m_YNDJGSPPY;
            }
            set
            {
                m_YNDJGSPPY = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGSPPY_PD
        /// </summary>
        public string YNDJGSPPY_PD
        {
            get
            {
                return m_YNDJGSPPY_PD;
            }
            set
            {
                m_YNDJGSPPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDZ_PD
        /// </summary>
        public string YNDZ_PD
        {
            get
            {
                return m_YNDZ_PD;
            }
            set
            {
                m_YNDZ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGGQ
        /// </summary>
        public string YWDYGGQ
        {
            get
            {
                return m_YWDYGGQ;
            }
            set
            {
                m_YWDYGGQ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGGQ_PD
        /// </summary>
        public string YWDYGGQ_PD
        {
            get
            {
                return m_YWDYGGQ_PD;
            }
            set
            {
                m_YWDYGGQ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGCZPYL
        /// </summary>
        public string YWDYGCZPYL
        {
            get
            {
                return m_YWDYGCZPYL;
            }
            set
            {
                m_YWDYGCZPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGSPPYL
        /// </summary>
        public string YWDYGSPPYL
        {
            get
            {
                return m_YWDYGSPPYL;
            }
            set
            {
                m_YWDYGSPPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGDG
        /// </summary>
        public string YWDYGDG
        {
            get
            {
                return m_YWDYGDG;
            }
            set
            {
                m_YWDYGDG = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGCZPY
        /// </summary>
        public string YWDYGCZPY
        {
            get
            {
                return m_YWDYGCZPY;
            }
            set
            {
                m_YWDYGCZPY = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGCZPY_PD
        /// </summary>
        public string YWDYGCZPY_PD
        {
            get
            {
                return m_YWDYGCZPY_PD;
            }
            set
            {
                m_YWDYGCZPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGSPPY
        /// </summary>
        public string YWDYGSPPY
        {
            get
            {
                return m_YWDYGSPPY;
            }
            set
            {
                m_YWDYGSPPY = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGSPPY_PD
        /// </summary>
        public string YWDYGSPPY_PD
        {
            get
            {
                return m_YWDYGSPPY_PD;
            }
            set
            {
                m_YWDYGSPPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGCZPYL
        /// </summary>
        public string YWDJGCZPYL
        {
            get
            {
                return m_YWDJGCZPYL;
            }
            set
            {
                m_YWDJGCZPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGSPPYL
        /// </summary>
        public string YWDJGSPPYL
        {
            get
            {
                return m_YWDJGSPPYL;
            }
            set
            {
                m_YWDJGSPPYL = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGDG
        /// </summary>
        public string YWDJGDG
        {
            get
            {
                return m_YWDJGDG;
            }
            set
            {
                m_YWDJGDG = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGCZPY
        /// </summary>
        public string YWDJGCZPY
        {
            get
            {
                return m_YWDJGCZPY;
            }
            set
            {
                m_YWDJGCZPY = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGCZPY_PD
        /// </summary>
        public string YWDJGCZPY_PD
        {
            get
            {
                return m_YWDJGCZPY_PD;
            }
            set
            {
                m_YWDJGCZPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGSPPY
        /// </summary>
        public string YWDJGSPPY
        {
            get
            {
                return m_YWDJGSPPY;
            }
            set
            {
                m_YWDJGSPPY = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGSPPY_PD
        /// </summary>
        public string YWDJGSPPY_PD
        {
            get
            {
                return m_YWDJGSPPY_PD;
            }
            set
            {
                m_YWDJGSPPY_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDZ_PD
        /// </summary>
        public string YWDZ_PD
        {
            get
            {
                return m_YWDZ_PD;
            }
            set
            {
                m_YWDZ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置DGZGQ
        /// </summary>
        public string DGZGQ
        {
            get
            {
                return m_DGZGQ;
            }
            set
            {
                m_DGZGQ = value;
            }
        }

        /// <summary>
        /// 获取或设置DGZGQ_PD
        /// </summary>
        public string DGZGQ_PD
        {
            get
            {
                return m_DGZGQ_PD;
            }
            set
            {
                m_DGZGQ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置DGGQXZ
        /// </summary>
        public string DGGQXZ
        {
            get
            {
                return m_DGGQXZ;
            }
            set
            {
                m_DGGQXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YGCZPYXZXX
        /// </summary>
        public string YGCZPYXZXX
        {
            get
            {
                return m_YGCZPYXZXX;
            }
            set
            {
                m_YGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置YGCZPYXZSX
        /// </summary>
        public string YGCZPYXZSX
        {
            get
            {
                return m_YGCZPYXZSX;
            }
            set
            {
                m_YGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置YGZDZPXZ
        /// </summary>
        public string YGZDZPXZ
        {
            get
            {
                return m_YGZDZPXZ;
            }
            set
            {
                m_YGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YGZDYPXZ
        /// </summary>
        public string YGZDYPXZ
        {
            get
            {
                return m_YGZDYPXZ;
            }
            set
            {
                m_YGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YGYDZPXZ
        /// </summary>
        public string YGYDZPXZ
        {
            get
            {
                return m_YGYDZPXZ;
            }
            set
            {
                m_YGYDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YGYDYPXZ
        /// </summary>
        public string YGYDYPXZ
        {
            get
            {
                return m_YGYDYPXZ;
            }
            set
            {
                m_YGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置JGCZPYXZXX
        /// </summary>
        public string JGCZPYXZXX
        {
            get
            {
                return m_JGCZPYXZXX;
            }
            set
            {
                m_JGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置JGCZPYXZSX
        /// </summary>
        public string JGCZPYXZSX
        {
            get
            {
                return m_JGCZPYXZSX;
            }
            set
            {
                m_JGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置JGZDZPXZ
        /// </summary>
        public string JGZDZPXZ
        {
            get
            {
                return m_JGZDZPXZ;
            }
            set
            {
                m_JGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置JGZDYPXZ
        /// </summary>
        public string JGZDYPXZ
        {
            get
            {
                return m_JGZDYPXZ;
            }
            set
            {
                m_JGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置JGYDZPXZ
        /// </summary>
        public string JGYDZPXZ
        {
            get
            {
                return m_JGYDZPXZ;
            }
            set
            {
                m_JGYDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置JGYDYPXZ
        /// </summary>
        public string JGYDYPXZ
        {
            get
            {
                return m_JGYDYPXZ;
            }
            set
            {
                m_JGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZGQXZ
        /// </summary>
        public string ZGQXZ
        {
            get
            {
                return m_ZGQXZ;
            }
            set
            {
                m_ZGQXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置DGZ_PD
        /// </summary>
        public string DGZ_PD
        {
            get
            {
                return m_DGZ_PD;
            }
            set
            {
                m_DGZ_PD = value;
            }
        }

        /// <summary>
        /// 获取或设置KSSJ
        /// </summary>
        public string KSSJ
        {
            get
            {
                return m_KSSJ;
            }
            set
            {
                m_KSSJ = value;
            }
        }

        /// <summary>
        /// 获取或设置JSSJ
        /// </summary>
        public string JSSJ
        {
            get
            {
                return m_JSSJ;
            }
            set
            {
                m_JSSJ = value;
            }
        }

        /// <summary>
        /// 获取或设置BIG1000JGCZPYXZXX
        /// </summary>
        public string BIG1000JGCZPYXZXX
        {
            get
            {
                return m_BIG1000JGCZPYXZXX;
            }
            set
            {
                m_BIG1000JGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置BIG1000JGCZPYXZSX
        /// </summary>
        public string BIG1000JGCZPYXZSX
        {
            get
            {
                return m_BIG1000JGCZPYXZSX;
            }
            set
            {
                m_BIG1000JGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDDGGQXZ
        /// </summary>
        public string ZWDDGGQXZ
        {
            get
            {
                return m_ZWDDGGQXZ;
            }
            set
            {
                m_ZWDDGGQXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGCZPYXZSX
        /// </summary>
        public string ZWDYGCZPYXZSX
        {
            get
            {
                return m_ZWDYGCZPYXZSX;
            }
            set
            {
                m_ZWDYGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGCZPYXZXX
        /// </summary>
        public string ZWDYGCZPYXZXX
        {
            get
            {
                return m_ZWDYGCZPYXZXX;
            }
            set
            {
                m_ZWDYGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGCZPYXZSX
        /// </summary>
        public string ZWDJGCZPYXZSX
        {
            get
            {
                return m_ZWDJGCZPYXZSX;
            }
            set
            {
                m_ZWDJGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGCZPYXZXX
        /// </summary>
        public string ZWDJGCZPYXZXX
        {
            get
            {
                return m_ZWDJGCZPYXZXX;
            }
            set
            {
                m_ZWDJGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGZDYPXZ
        /// </summary>
        public string ZWDYGZDYPXZ
        {
            get
            {
                return m_ZWDYGZDYPXZ;
            }
            set
            {
                m_ZWDYGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGZDZPXZ
        /// </summary>
        public string ZWDYGZDZPXZ
        {
            get
            {
                return m_ZWDYGZDZPXZ;
            }
            set
            {
                m_ZWDYGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGYDYPXZ
        /// </summary>
        public string ZWDYGYDYPXZ
        {
            get
            {
                return m_ZWDYGYDYPXZ;
            }
            set
            {
                m_ZWDYGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDYGYDZPXZ
        /// </summary>
        public string ZWDYGYDZPXZ
        {
            get
            {
                return m_ZWDYGYDZPXZ;
            }
            set
            {
                m_ZWDYGYDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGZDYPXZ
        /// </summary>
        public string ZWDJGZDYPXZ
        {
            get
            {
                return m_ZWDJGZDYPXZ;
            }
            set
            {
                m_ZWDJGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGZDZPXZ
        /// </summary>
        public string ZWDJGZDZPXZ
        {
            get
            {
                return m_ZWDJGZDZPXZ;
            }
            set
            {
                m_ZWDJGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGYDYPXZ
        /// </summary>
        public string ZWDJGYDYPXZ
        {
            get
            {
                return m_ZWDJGYDYPXZ;
            }
            set
            {
                m_ZWDJGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZWDJGYDZPXZ
        /// </summary>
        public string ZWDJGYDZPXZ
        {
            get
            {
                return m_ZWDJGYDZPXZ;
            }
            set
            {
                m_ZWDJGYDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDDGGQXZ
        /// </summary>
        public string ZNDDGGQXZ
        {
            get
            {
                return m_ZNDDGGQXZ;
            }
            set
            {
                m_ZNDDGGQXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGCZPYXZSX
        /// </summary>
        public string ZNDYGCZPYXZSX
        {
            get
            {
                return m_ZNDYGCZPYXZSX;
            }
            set
            {
                m_ZNDYGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGCZPYXZXX
        /// </summary>
        public string ZNDYGCZPYXZXX
        {
            get
            {
                return m_ZNDYGCZPYXZXX;
            }
            set
            {
                m_ZNDYGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGCZPYXZSX
        /// </summary>
        public string ZNDJGCZPYXZSX
        {
            get
            {
                return m_ZNDJGCZPYXZSX;
            }
            set
            {
                m_ZNDJGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGCZPYXZXX
        /// </summary>
        public string ZNDJGCZPYXZXX
        {
            get
            {
                return m_ZNDJGCZPYXZXX;
            }
            set
            {
                m_ZNDJGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGZDYPXZ
        /// </summary>
        public string ZNDYGZDYPXZ
        {
            get
            {
                return m_ZNDYGZDYPXZ;
            }
            set
            {
                m_ZNDYGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGZDZPXZ
        /// </summary>
        public string ZNDYGZDZPXZ
        {
            get
            {
                return m_ZNDYGZDZPXZ;
            }
            set
            {
                m_ZNDYGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGYDYPXZ
        /// </summary>
        public string ZNDYGYDYPXZ
        {
            get
            {
                return m_ZNDYGYDYPXZ;
            }
            set
            {
                m_ZNDYGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDYGYDZPXZ
        /// </summary>
        public string ZNDYGYDZPXZ
        {
            get
            {
                return m_ZNDYGYDZPXZ;
            }
            set
            {
                m_ZNDYGYDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGZDYPXZ
        /// </summary>
        public string ZNDJGZDYPXZ
        {
            get
            {
                return m_ZNDJGZDYPXZ;
            }
            set
            {
                m_ZNDJGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGZDZPXZ
        /// </summary>
        public string ZNDJGZDZPXZ
        {
            get
            {
                return m_ZNDJGZDZPXZ;
            }
            set
            {
                m_ZNDJGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGYDYPXZ
        /// </summary>
        public string ZNDJGYDYPXZ
        {
            get
            {
                return m_ZNDJGYDYPXZ;
            }
            set
            {
                m_ZNDJGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置ZNDJGYDZPXZ
        /// </summary>
        public string ZNDJGYDZPXZ
        {
            get
            {
                return m_ZNDJGYDZPXZ;
            }
            set
            {
                m_ZNDJGYDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDDGGQXZ
        /// </summary>
        public string YNDDGGQXZ
        {
            get
            {
                return m_YNDDGGQXZ;
            }
            set
            {
                m_YNDDGGQXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGCZPYXZSX
        /// </summary>
        public string YNDYGCZPYXZSX
        {
            get
            {
                return m_YNDYGCZPYXZSX;
            }
            set
            {
                m_YNDYGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGCZPYXZXX
        /// </summary>
        public string YNDYGCZPYXZXX
        {
            get
            {
                return m_YNDYGCZPYXZXX;
            }
            set
            {
                m_YNDYGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGCZPYXZSX
        /// </summary>
        public string YNDJGCZPYXZSX
        {
            get
            {
                return m_YNDJGCZPYXZSX;
            }
            set
            {
                m_YNDJGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGCZPYXZXX
        /// </summary>
        public string YNDJGCZPYXZXX
        {
            get
            {
                return m_YNDJGCZPYXZXX;
            }
            set
            {
                m_YNDJGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGZDYPXZ
        /// </summary>
        public string YNDYGZDYPXZ
        {
            get
            {
                return m_YNDYGZDYPXZ;
            }
            set
            {
                m_YNDYGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGZDZPXZ
        /// </summary>
        public string YNDYGZDZPXZ
        {
            get
            {
                return m_YNDYGZDZPXZ;
            }
            set
            {
                m_YNDYGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGYDYPXZ
        /// </summary>
        public string YNDYGYDYPXZ
        {
            get
            {
                return m_YNDYGYDYPXZ;
            }
            set
            {
                m_YNDYGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDYGYDZPXZ
        /// </summary>
        public string YNDYGYDZPXZ
        {
            get
            {
                return m_YNDYGYDZPXZ;
            }
            set
            {
                m_YNDYGYDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGZDYPXZ
        /// </summary>
        public string YNDJGZDYPXZ
        {
            get
            {
                return m_YNDJGZDYPXZ;
            }
            set
            {
                m_YNDJGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGZDZPXZ
        /// </summary>
        public string YNDJGZDZPXZ
        {
            get
            {
                return m_YNDJGZDZPXZ;
            }
            set
            {
                m_YNDJGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGYDYPXZ
        /// </summary>
        public string YNDJGYDYPXZ
        {
            get
            {
                return m_YNDJGYDYPXZ;
            }
            set
            {
                m_YNDJGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YNDJGYDZPXZ
        /// </summary>
        public string YNDJGYDZPXZ
        {
            get
            {
                return m_YNDJGYDZPXZ;
            }
            set
            {
                m_YNDJGYDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDDGGQXZ
        /// </summary>
        public string YWDDGGQXZ
        {
            get
            {
                return m_YWDDGGQXZ;
            }
            set
            {
                m_YWDDGGQXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGCZPYXZSX
        /// </summary>
        public string YWDYGCZPYXZSX
        {
            get
            {
                return m_YWDYGCZPYXZSX;
            }
            set
            {
                m_YWDYGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGCZPYXZXX
        /// </summary>
        public string YWDYGCZPYXZXX
        {
            get
            {
                return m_YWDYGCZPYXZXX;
            }
            set
            {
                m_YWDYGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGCZPYXZSX
        /// </summary>
        public string YWDJGCZPYXZSX
        {
            get
            {
                return m_YWDJGCZPYXZSX;
            }
            set
            {
                m_YWDJGCZPYXZSX = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGCZPYXZXX
        /// </summary>
        public string YWDJGCZPYXZXX
        {
            get
            {
                return m_YWDJGCZPYXZXX;
            }
            set
            {
                m_YWDJGCZPYXZXX = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGZDYPXZ
        /// </summary>
        public string YWDYGZDYPXZ
        {
            get
            {
                return m_YWDYGZDYPXZ;
            }
            set
            {
                m_YWDYGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGZDZPXZ
        /// </summary>
        public string YWDYGZDZPXZ
        {
            get
            {
                return m_YWDYGZDZPXZ;
            }
            set
            {
                m_YWDYGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGYDYPXZ
        /// </summary>
        public string YWDYGYDYPXZ
        {
            get
            {
                return m_YWDYGYDYPXZ;
            }
            set
            {
                m_YWDYGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDYGYDZPXZ
        /// </summary>
        public string YWDYGYDZPXZ
        {
            get
            {
                return m_YWDYGYDZPXZ;
            }
            set
            {
                m_YWDYGYDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGZDYPXZ
        /// </summary>
        public string YWDJGZDYPXZ
        {
            get
            {
                return m_YWDJGZDYPXZ;
            }
            set
            {
                m_YWDJGZDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGZDZPXZ
        /// </summary>
        public string YWDJGZDZPXZ
        {
            get
            {
                return m_YWDJGZDZPXZ;
            }
            set
            {
                m_YWDJGZDZPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGYDYPXZ
        /// </summary>
        public string YWDJGYDYPXZ
        {
            get
            {
                return m_YWDJGYDYPXZ;
            }
            set
            {
                m_YWDJGYDYPXZ = value;
            }
        }

        /// <summary>
        /// 获取或设置YWDJGYDZPXZ
        /// </summary>
        public string YWDJGYDZPXZ
        {
            get
            {
                return m_YWDJGYDZPXZ;
            }
            set
            {
                m_YWDJGYDZPXZ = value;
            }
        }


    }
}
