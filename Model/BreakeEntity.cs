using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class BreakeEntity
    {

        public string JCCS
        {
            get;
            set;
        }

        public string ZLZ
        {
            get;
            set;
        }

        public string YLZ
        {
            get;
            set;
        }

        public string ZZ
        {
            get
            {
                if ((ZLZ.ToDouble() + YLZ.ToDouble()) == 0)
                {
                    return string.Empty;
                }

                return (ZLZ.ToDouble() + YLZ.ToDouble()).ToString();
            }
        }

        public string ZDTLH
        {
            get;
            set;
        }

        public string YDTLH
        {
            get;
            set;
        }

        public string DTLH
        {
            get
            {
                if ((ZDTLH.ToDouble() + YDTLH.ToDouble()) == 0)
                {
                    return string.Empty;
                }

                return (ZDTLH.ToDouble() + YDTLH.ToDouble()).ToString();
            }
        }

        public string ZZDCZD
        {
            get;
            set;
        }

        public string YZDCZD
        {
            get;
            set;
        }

        public string BPHLV
        {
            get
            {
                /*
                轴制动率=（左制动力+右制动力）/ 轴重
                前轴或制动率大于60%时不平衡率=（左过程差最大值点-右过程差最大值点）的绝对值 / 轴最大制动力 
                后轴或制动率小于60%时不平衡率= (左过程差最大值点-右过程差最大值点) 的绝对值 / 轴重
                */
                return string.Empty;
            }
            

        }

        public string BPHLV_PD
        {
            get;
            set;

        }

        public string ZZDZDL
        {
            get;
            set;
        }

        public string YZDZDL
        {
            get;
            set;
        }

        public string ZDLV
        {
            get
            {
                if (DTLH.ToDouble() > 0)
                {

                    return Math.Round((ZZDZDL.ToDouble() + YZDZDL.ToDouble()) * 100 / (DTLH.ToDouble() * 0.98), 1).ToString();
                }
                else
                {
                    if (ZZ.ToDouble() == 0)
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return Math.Round((ZZDZDL.ToDouble() + YZDZDL.ToDouble()) * 100 / (ZZ.ToDouble() * 0.98), 1).ToString();
                    }
                }
            }

        }

        public int ZDLV_PD
        {
            get
            {
                if (ZDLV.ToDouble() >= ZDLVBZ.ToDouble())
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

        }

        public string ZSZDL
        {
            get;
            set;
        }

        public string YSZDL
        {
            get;
            set;
        }

        public string SZDL
        {
            get;
            set;
        }

        public string JZZZ
        {
            get;
            set;
        }

        public string JZZDLV
        {
            get;
            set;

        }

        public string JZZDLV_PD
        {
            get;
            set;

        }

        public string JZBPHLV
        {
            get;
            set;

        }

        public string JZBPHLV_PD
        {
            get;
            set;

        }

        public string ZDZ_PD
        {
            get;
            set;

        }

        public string BPHLVBZ
        {
            get;
            set;
        }

        public string ZDLVBZ
        {
            get;
            set;
        }

        public string FHTZZ
        {
            get;
            set;
        }

        public string FHTZLZ
        {
            get;
            set;
        }

        public string FHTYLZ
        {
            get;
            set;
        }

        public string JZZDLVBZ
        {
            get;
            set;
        }

        public string JZZZDL
        {
            get;
            set;
        }

        public string JZYZDL
        {
            get;
            set;
        }

        public string JZZZDCZD
        {
            get;
            set;
        }

        public string JZYZDCZD
        {
            get;
            set;
        }

    }
}
