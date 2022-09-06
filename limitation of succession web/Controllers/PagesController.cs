using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using limitation_of_succession_web.Models;
using maghriby.Helpers;
using System.Data;

namespace limitation_of_succession_web.Controllers
{
    public class PagesController : Controller
    {
        public static double money;
        public static string national_number;
        public static double is_there_sons = 0, sons_nums, sons_part0 = 0;
        public static double is_there_girls = 0, girls_part_2 = 12, girls_part_3 = 16, girls_nums, girls_part0 = 0;
        public static double is_there_father = 0, father_part = 4, father_part0 = 0;
        public static double is_there_mother = 0, mother_part_1 = 4, mother_part_2 = 8, mother_part0 = 0;
        public static double is_there_husband = 0, husband_part_1 = 6, husband_part_2 = 12, husband_part0 = 0;
        public static double is_there_wife = 0, wife_part_1 = 3, wife_part_2 = 6, wives_nums, wife_part0 = 0;
        public static double is_there_brothers = 0, brothers_nums, brothers_part0 = 0;
        public static double is_there_sisters = 0, sisters_part_2 = 12, sisters_part_3 = 16, sisters_nums, sisters_part0 = 0;
        public static double is_there_bro_sons = 0, bro_sons_nums, bro_sons_part0 = 0;
        public static double is_there_m_stepbrothers = 0, m_stepbrothers_nums, m_stepbrothers_part1 = 4, m_stepbrothers_part2 = 8, m_stepbrothers_part0 = 0;
        public static double is_there_uncles = 0, uncles_nums, uncles_part0 = 0;
        public static double is_there_f_stepbrothers = 0, f_stepbrothers_nums, f_stepbrothers_part0 = 0;
        public static double is_there_f_stepsisters = 0, f_stepsisters_nums, f_stepsisters_part0 = 0;
        public IActionResult First_Page()
        {
            return View();
        }
        public IActionResult Second_Page()
        {
            return View();
        }
        public IActionResult Third_Page()
        {
            List<heirs> heir = new List<heirs>();
            heir.Add(new heirs
            {
                existing = is_there_husband,
                heir = "الزوج",
                part = husband_part0,
                part1 = husband_part0,
            });
            heir.Add(new heirs
            {
                existing = is_there_wife,
                heir = "الزوجة",
                part = wife_part0,
                part1 = wife_part0 / wives_nums,
            });
            heir.Add(new heirs
            {
                existing = is_there_sons,
                heir = "أولاد",
                part = sons_part0,
                part1 = sons_part0 / sons_nums,
            });
            heir.Add(new heirs
            {
                existing = is_there_girls,
                heir = "بنات",
                part = girls_part0,
                part1 = girls_part0 / girls_nums,
            });
            heir.Add(new heirs
            {
                existing = is_there_father,
                heir = "أب",
                part = father_part0,
                part1 = father_part0,
            });
            heir.Add(new heirs
            {
                existing = is_there_mother,
                heir = "أم",
                part = mother_part0,
                part1 = mother_part0,
            });
            heir.Add(new heirs
            {
                existing = is_there_brothers,
                heir = "أشقاء",
                part = brothers_part0,
                part1 = brothers_part0 / brothers_nums,
            });
            heir.Add(new heirs
            {
                existing = is_there_sisters,
                heir = "شقيقات",
                part = sisters_part0,
                part1 = sisters_part0 / sisters_nums,
            });
            heir.Add(new heirs
            {
                existing = is_there_m_stepbrothers,
                heir = "أخوة لأم",
                part = m_stepbrothers_part0,
                part1 = m_stepbrothers_part0 / m_stepbrothers_nums,
            });
            heir.Add(new heirs
            {
                existing = is_there_f_stepbrothers,
                heir = "أخوة لأب",
                part = f_stepbrothers_part0,
                part1 = f_stepbrothers_part0 / f_stepbrothers_nums,
            });
            heir.Add(new heirs
            {
                existing = is_there_f_stepsisters,
                heir = "خوات لأب",
                part = f_stepsisters_part0,
                part1 = f_stepsisters_part0 / f_stepsisters_nums,
            });
            heir.Add(new heirs
            {
                existing = is_there_bro_sons,
                heir = "أبناء الأخوة",
                part = bro_sons_part0,
                part1 = bro_sons_part0 / bro_sons_nums,
            });
            heir.Add(new heirs
            {
                existing = is_there_uncles,
                heir = "أعمام",
                part = uncles_part0,
                part1 = uncles_part0 / uncles_nums,
            });
            ViewBag.Heirs = heir.ToArray();
            ViewBag.number = national_number;
            ViewBag.money = money;
            return View();
        }
        [HttpPost]
        public async Task<string> search([FromForm] string national_number0)
        {
                if (national_number0.Length == 11)
            {
                DAL d = new DAL();
                string query = "select * from heirs where National_Number = '{0}'";
                DataTable dt = await d.selectdataasync(string.Format(query, national_number0));
                if (dt.Rows.Count > 0)
                {
                    try
                    {
                        money = Convert.ToDouble(dt.Rows[0]["Money"]);
                        national_number = dt.Rows[0]["National_Number"].ToString();
                        is_there_husband = Convert.ToDouble(dt.Rows[0]["husband"]);
                        husband_part0 = Convert.ToDouble(dt.Rows[0]["husband_part"]);
                        is_there_wife = Convert.ToDouble(dt.Rows[0]["wife"]);
                        wife_part0 = Convert.ToDouble(dt.Rows[0]["wife_part"]);
                        is_there_sons = Convert.ToDouble(dt.Rows[0]["boys"]);
                        sons_part0 = Convert.ToDouble(dt.Rows[0]["boys_part"]);
                        is_there_girls = Convert.ToDouble(dt.Rows[0]["girls"]);
                        girls_part0 = Convert.ToDouble(dt.Rows[0]["girls_part"]);
                        is_there_father = Convert.ToDouble(dt.Rows[0]["father"]);
                        father_part0 = Convert.ToDouble(dt.Rows[0]["father_part"]);
                        is_there_mother = Convert.ToDouble(dt.Rows[0]["mother"]);
                        mother_part0 = Convert.ToDouble(dt.Rows[0]["mother_part"]);
                        is_there_brothers = Convert.ToDouble(dt.Rows[0]["brothers"]);
                        brothers_part0 = Convert.ToDouble(dt.Rows[0]["brothers_part"]);
                        is_there_sisters = Convert.ToDouble(dt.Rows[0]["sisters"]);
                        sisters_part0 = Convert.ToDouble(dt.Rows[0]["sisters_part"]);
                        is_there_m_stepbrothers = Convert.ToDouble(dt.Rows[0]["m_stepbrothers"]);
                        m_stepbrothers_part0 = Convert.ToDouble(dt.Rows[0]["m_stepbrothers_part"]);
                        is_there_f_stepbrothers = Convert.ToDouble(dt.Rows[0]["f_stepbrothers"]);
                        f_stepbrothers_part0 = Convert.ToDouble(dt.Rows[0]["f_stepbrothers_part"]);
                        is_there_f_stepsisters = Convert.ToDouble(dt.Rows[0]["f_stepsisters"]);
                        f_stepsisters_part0 = Convert.ToDouble(dt.Rows[0]["f_stepsisters_part"]);
                        is_there_bro_sons = Convert.ToDouble(dt.Rows[0]["bro_sons"]);
                        bro_sons_part0 = Convert.ToDouble(dt.Rows[0]["bro_sons_part"]);
                        is_there_uncles = Convert.ToDouble(dt.Rows[0]["uncles"]);
                        uncles_part0 = Convert.ToDouble(dt.Rows[0]["uncles_part"]);
                        wives_nums = Convert.ToDouble(dt.Rows[0]["wives_nums"]);
                        sons_nums = Convert.ToDouble(dt.Rows[0]["boys_nums"]);
                        girls_nums = Convert.ToDouble(dt.Rows[0]["girls_nums"]);
                        brothers_nums = Convert.ToDouble(dt.Rows[0]["brothers_nums"]);
                        sisters_nums = Convert.ToDouble(dt.Rows[0]["sisters_nums"]);
                        m_stepbrothers_nums = Convert.ToDouble(dt.Rows[0]["m_stepbrothers_nums"]);
                        f_stepbrothers_nums = Convert.ToDouble(dt.Rows[0]["f_stepbrothers_nums"]);
                        f_stepsisters_nums = Convert.ToDouble(dt.Rows[0]["f_stepsisters_nums"]);
                        bro_sons_nums = Convert.ToDouble(dt.Rows[0]["bro_sons_nums"]);
                        uncles_nums = Convert.ToDouble(dt.Rows[0]["uncles_nums"]);
                        return "success";
                    }
                    catch (Exception e)
                    {

                    }
                }
                else
                {
                    return "no idnum";
                }
            }
            else
            {
                return "not 11";
            }
            return "Something went wrong !";
        }
        [HttpPost]
        public async Task<string> limitaion([FromForm] double[] model, [FromForm] double[] model1, [FromForm]double moneym, [FromForm]string national_number1)
        {
            if(national_number1.Length == 11)
            {
                DAL d = new DAL();
                string query = "select * from heirs where National_Number = '{0}'";
                DataTable dt = await d.selectdataasync(string.Format(query, national_number1));
                if (dt.Rows.Count > 0)
                {
                    return "This Id number is exist";
                }
                try
                {
                    double div = 24;
                    double div1 = 0;
                    double x;
                    money = moneym;
                    national_number = national_number1;
                    is_there_husband = model[0];
                    is_there_wife = model[1];
                    is_there_sons = model[2];
                    is_there_girls = model[3];
                    is_there_father = model[4];
                    is_there_mother = model[5];
                    is_there_brothers = model[6];
                    is_there_sisters = model[7];
                    is_there_m_stepbrothers = model[8];
                    is_there_f_stepbrothers = model[9];
                    is_there_f_stepsisters = model[10];
                    is_there_bro_sons = model[11];
                    is_there_uncles = model[12];
                    wives_nums = model1[0];
                    sons_nums = model1[1];
                    girls_nums = model1[2];
                    brothers_nums = model1[3];
                    sisters_nums = model1[4];
                    m_stepbrothers_nums = model1[5];
                    f_stepbrothers_nums = model1[6];
                    f_stepsisters_nums = model1[7];
                    bro_sons_nums = model1[8];
                    uncles_nums = model1[9];
                    double bs = brothers_nums + sisters_nums;
                    if (is_there_sons == 1 || is_there_girls == 1)
                    {
                        div1 = div1 + (is_there_husband * husband_part_1) + (is_there_wife * wife_part_1);
                    }
                    else
                    {
                        div1 = div1 + (is_there_husband * husband_part_2) + (is_there_wife * wife_part_2);
                    }
                    if (is_there_sons == 1 || is_there_girls == 1 || bs > 1)
                    {
                        div1 = div1 + (is_there_mother * mother_part_1);
                    }
                    else
                    {
                        div1 = div1 + (is_there_mother * mother_part_2);
                    }
                    if (is_there_sons == 0 && is_there_girls == 1)
                    {
                        if (girls_nums > 1)
                        {
                            div1 = div1 + girls_part_3;
                        }
                        else
                        {
                            div1 = div1 + girls_part_2;
                        }
                    }
                    div1 = div1 + (is_there_father * father_part);
                    if (is_there_sons == 0 && is_there_father == 0 && is_there_girls == 0 && is_there_brothers == 0 && is_there_sisters == 1)
                    {
                        if (sisters_nums > 1)
                        {
                            div1 = div1 + sisters_part_3;
                        }
                        else
                        {
                            div1 = div1 + sisters_part_2;
                        }
                    }
                    if (is_there_sons == 0 && is_there_father == 0 && is_there_girls == 0 && is_there_m_stepbrothers == 1)
                    {
                        if (m_stepbrothers_nums > 1)
                        {
                            div1 = div1 + m_stepbrothers_part2;
                        }
                        else
                        {
                            div1 = div1 + m_stepbrothers_part1;
                        }
                    }
                    if (div1 > 24)
                    {
                        x = money / div1;
                    }
                    else
                    {
                        x = money / div;
                    }
                    //cout << x << endl;

                    wife_part0 = (wife_part_1 * x) * is_there_wife;
                    husband_part0 = is_there_husband * husband_part_1 * x;
                    mother_part0 = is_there_mother * mother_part_1 * x;
                    if (is_there_sons == 1)
                    {
                        father_part0 = is_there_father * father_part * x;
                        double r = money - (wife_part0 + husband_part0 + mother_part0 + father_part0);
                        double boys = sons_nums * 2;
                        double child_part = r / (boys + girls_nums);

                        sons_part0 = sons_nums * child_part * 2;
                        girls_part0 = girls_nums * child_part;
                    }
                    if (is_there_sons == 0)
                    {
                        if (is_there_girls == 1)
                        {
                            if (girls_nums == 1)
                            {
                                girls_part0 = girls_part_2 * x;
                            }
                            else if (girls_nums > 1)
                            {
                                girls_part0 = girls_part_3 * x;
                            }
                            father_part0 = (money - (wife_part0 + husband_part0 + mother_part0 + girls_part0)) * is_there_father;
                        }
                        else
                        {
                            if (is_there_father == 1 && is_there_mother == 1 && (is_there_wife == 1 || is_there_husband == 1))
                            {
                                wife_part0 = is_there_wife * wife_part_2 * x;
                                husband_part0 = is_there_husband * husband_part_2 * x;
                                double r1 = money - (wife_part0 + husband_part0);
                                mother_part0 = r1 / 3;
                                father_part0 = r1 - mother_part0;
                            }
                            else
                            {
                                wife_part0 = is_there_wife * wife_part_2 * x;
                                husband_part0 = is_there_husband * husband_part_2 * x;
                                double n = brothers_nums + sisters_nums;
                                if (n > 1)
                                {
                                    mother_part0 = is_there_mother * mother_part_1 * x;
                                }
                                else
                                {
                                    mother_part0 = is_there_mother * mother_part_2 * x;
                                }
                                father_part0 = (money - (wife_part0 + husband_part0 + mother_part0)) * is_there_father;
                            }
                        }
                        if (is_there_sons == 0 && is_there_father == 0)
                        {
                            if (is_there_girls == 0 && is_there_m_stepbrothers == 1)
                            {
                                if (m_stepbrothers_nums > 1)
                                {
                                    m_stepbrothers_part0 = m_stepbrothers_part2 * x;
                                }
                                else
                                {
                                    m_stepbrothers_part0 = m_stepbrothers_part1 * x;
                                }
                            }
                            if (is_there_brothers == 1)
                            {
                                double rest = money - (wife_part0 + husband_part0 + mother_part0 + girls_part0);
                                double broes = brothers_nums * 2;
                                double money0 = rest / (broes + sisters_nums);
                                brothers_part0 = money0 * broes;
                                sisters_part0 = money0 * sisters_nums;
                            }
                            else
                            {
                                if (is_there_girls == 0)
                                {
                                    if (is_there_sisters == 1)
                                    {
                                        if (is_there_sisters == 1)
                                        {
                                            sisters_part0 = sisters_part_2 * x;
                                        }
                                        else if (sisters_nums > 1)
                                        {
                                            sisters_part0 = sisters_part_3 * x;
                                        }
                                    }
                                }
                                else if (is_there_girls == 1 && is_there_sisters == 1)
                                {
                                    double money1 = money - (wife_part0 + husband_part0 + mother_part0 + girls_part0);
                                    sisters_part0 = money1;
                                }
                                if (is_there_f_stepbrothers == 1 && (is_there_sisters == 0 || is_there_girls == 0))
                                {
                                    double money1 = money - (wife_part0 + husband_part0 + mother_part0 + girls_part0 + sisters_part0);
                                    double f_broes = f_stepbrothers_nums * 2;
                                    double money0 = money1 / (f_broes + f_stepsisters_nums);
                                    f_stepbrothers_part0 = money0 * f_broes;
                                    f_stepsisters_part0 = money0 * f_stepsisters_nums;
                                }
                                if (is_there_bro_sons == 1 && (is_there_sisters == 0 || is_there_girls == 0) && is_there_f_stepbrothers == 0)
                                {
                                    double money1 = money - (wife_part0 + husband_part0 + mother_part0 + girls_part0 + sisters_part0);
                                    bro_sons_part0 = money1;
                                }
                                if (is_there_bro_sons == 0 && (is_there_sisters == 0 || is_there_girls == 0) && is_there_uncles == 1)
                                {
                                    double money1 = money - (wife_part0 + husband_part0 + mother_part0 + girls_part0 + sisters_part0);
                                    uncles_part0 = money1;
                                }
                                if (is_there_sons == 0 && is_there_father == 0 && is_there_brothers == 0 && (is_there_sisters == 0 || is_there_girls == 0) && is_there_bro_sons == 0 && is_there_uncles == 0)
                                {
                                    double money1 = money - (wife_part0 + husband_part0 + mother_part0 + girls_part0 + sisters_part0 + m_stepbrothers_part0);
                                    if (money1 > 0)
                                    {
                                        double bs1 = brothers_nums + sisters_nums;
                                        double div2 = 0;
                                        if (is_there_sons == 1 || is_there_girls == 1 || bs1 > 1)
                                        {
                                            div2 = div2 + (is_there_mother * mother_part_1);
                                        }
                                        else
                                        {
                                            div2 = div2 + (is_there_mother * mother_part_2);
                                        }
                                        if (is_there_sons == 0 && is_there_girls == 1)
                                        {
                                            if (girls_nums > 1)
                                            {
                                                div2 = div2 + girls_part_3;
                                            }
                                            else
                                            {
                                                div2 = div2 + girls_part_2;
                                            }
                                        }
                                        if (is_there_bro_sons == 0 && is_there_father == 0 && is_there_girls == 0 && is_there_brothers == 0 && is_there_sisters == 1)
                                        {
                                            if (sisters_nums > 1)
                                            {
                                                div2 = div2 + sisters_part_3;
                                            }
                                            else
                                            {
                                                div2 = div2 + sisters_part_2;
                                            }
                                        }
                                        if (is_there_sons == 0 && is_there_father == 0 && is_there_girls == 0 && m_stepbrothers_nums == 1)
                                        {
                                            if (m_stepbrothers_nums > 1)
                                            {
                                                div2 = div2 + m_stepbrothers_part2;
                                            }
                                            else
                                            {
                                                div2 = div2 + m_stepbrothers_part1;
                                            }
                                        }
                                        double money2 = money1 / div2;
                                        if (is_there_sons == 1 || is_there_girls == 1 || bs1 > 1)
                                        {
                                            mother_part0 = mother_part0 + (is_there_mother * mother_part_1 * money2);
                                        }
                                        else
                                        {
                                            mother_part0 = mother_part0 + (is_there_mother * mother_part_2 * money2);
                                        }
                                        if (is_there_sons == 0 && is_there_girls == 1)
                                        {
                                            if (girls_nums > 1)
                                            {
                                                girls_part0 = girls_part0 + (girls_part_3 * money2);
                                            }
                                            else
                                            {
                                                girls_part0 = girls_part0 + (girls_part_2 * money2);
                                            }
                                        }
                                        if (is_there_sons == 0 && is_there_father == 0 && is_there_girls == 0 && is_there_brothers == 0 && is_there_sisters == 1)
                                        {
                                            if (sisters_nums > 1)
                                            {
                                                sisters_part0 = sisters_part0 + (sisters_part_3 * money2);
                                            }
                                            else
                                            {
                                                sisters_part0 = sisters_part0 + (sisters_part_2 * money2);
                                            }
                                        }
                                        if (is_there_sons == 0 && is_there_father == 0 && is_there_girls == 0 && is_there_m_stepbrothers == 1)
                                        {
                                            if (m_stepbrothers_nums > 1)
                                            {
                                                m_stepbrothers_part0 = m_stepbrothers_part0 + (m_stepbrothers_part2 * money2);
                                            }
                                            else
                                            {
                                                m_stepbrothers_part0 = m_stepbrothers_part0 + (m_stepbrothers_part1 * money2);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    string query1 = "INSERT INTO heirs (National_Number, Money,husband ,husband_part,wife,wife_part,wives_nums,boys,boys_part,boys_nums,girls,girls_part,girls_nums,father,father_part,mother,mother_part,brothers,brothers_part,brothers_nums,sisters,sisters_part,sisters_nums,m_stepbrothers,m_stepbrothers_part,m_stepbrothers_nums,f_stepbrothers,f_stepbrothers_part,f_stepbrothers_nums,f_stepsisters,f_stepsisters_part,f_stepsisters_nums,bro_sons,bro_sons_part,bro_sons_nums,uncles,uncles_part,uncles_nums ) " +
                        "VALUES('{0}', '{1}','{2}' ,'{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}','{32}','{33}','{34}','{35}','{36}','{37}' ) ";
                    await d.insertdataasync(string.Format(query1, national_number, money, is_there_husband, husband_part0, is_there_wife, wife_part0, wives_nums, is_there_sons, sons_part0, sons_nums, is_there_girls, girls_part0, girls_nums, is_there_father, father_part0, is_there_mother, mother_part0, is_there_brothers, brothers_part0, brothers_nums, is_there_sisters, sisters_part0, sisters_nums, is_there_m_stepbrothers, m_stepbrothers_part0, m_stepbrothers_nums, is_there_f_stepbrothers, f_stepbrothers_part0, f_stepbrothers_nums, f_stepbrothers_nums, is_there_f_stepsisters, f_stepsisters_part0, f_stepsisters_nums, is_there_bro_sons, bro_sons_part0, bro_sons_nums, is_there_uncles, uncles_part0, uncles_nums));
                    return "success";
                }
                catch (Exception e)
                {
                    return "error";
                }
            }
            else
            {
                return "not 11";
            }
        }
    }
}