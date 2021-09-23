using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.Drawing;

namespace Raktár_v._2
{
    class Seged
    {//
        public static SqlConnection con = new SqlConnection($@"Data Source=mssql-43715-0.cloudclusters.net,17445;Initial Catalog=ProbaDB;User ID=Andor;Password=Asdqwe123");
        

        public static void Tortenet(string _nev, string _cselekmeny)
        {
            con.Open();

            SqlCommand com = new SqlCommand("INSERT INTO raktartortenet (Felhasznalo,Cselekmeny,Datum) VALUES" +
                "(@felh,@cselekmeny,@datum)",con);
            com.Parameters.AddWithValue("@felh",_nev);
            com.Parameters.AddWithValue("@cselekmeny",_cselekmeny);
            com.Parameters.AddWithValue("@datum",DateTime.Now);
            com.ExecuteNonQuery();

            con.Close();
        }

        internal static void Kapcsolat_ellenorzes()
        {
            try
            {
               
                con.Open();
                SqlCommand com = new SqlCommand("select * from felhasznalok", con);
                com.ExecuteNonQuery();
                con.Close();
                Login l = new Login();
                l.ShowDialog();
            }
            catch (Exception)
            {
                Connect c = new Connect();
                c.ShowDialog();
            }
            
            
             
        }

        #region Login
        internal static byte[] HASH_jelszo(string _jelszo)
        {
            
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(_jelszo);
            byte[] result = sha512.ComputeHash(bytes);
            return result;
        }

        

        internal static int UserID_feltoltes(string _username, string _pass)
        {
            con.Open();

            SqlCommand com = new SqlCommand("select f.ID from felhasznalok f where f.Felh_nev = @nev and f.Jelszo = @jelszo",con);
            com.Parameters.AddWithValue("@nev", _username);
            com.Parameters.AddWithValue("@jelszo", Seged.HASH_jelszo(_pass));
            com.ExecuteNonQuery();
            int result = Convert.ToInt32(com.ExecuteScalar());

            con.Close();
            return result;
        }

        

        internal static string Jog_Login(string _username, string _pass)
        {
            string result;
            con.Open();

            SqlCommand com = new SqlCommand(@"SELECT Jog FROM felhasznalok WHERE Felh_nev = @felhnev and Jelszo = @jelszo",con);
            com.Parameters.AddWithValue("@felhnev", _username);
            com.Parameters.AddWithValue("@jelszo", Seged.HASH_jelszo(_pass));
            com.ExecuteNonQuery();
            result = com.ExecuteScalar().ToString();
            con.Close();
            Tortenet(_username,"Belépés");
            return result;
        }

        

        internal static int User_Validalas(string _username, string _pass)
        {
            con.Open();

            SqlCommand com = new SqlCommand(@"SELECT count(*) FROM felhasznalok WHERE Felh_nev = @felhnev and Jelszo = @jelszo",con);
            com.Parameters.AddWithValue("@felhnev", _username);
            com.Parameters.AddWithValue("@jelszo", Seged.HASH_jelszo(_pass));
            com.ExecuteNonQuery();

            int result = Convert.ToInt32(com.ExecuteScalar());

            con.Close();

            return result;
        }

        


        #endregion Login
        #region Regisztaracio
        internal static int Reg_Validalas(string _username)
        {
            con.Open();
            SqlCommand com = new SqlCommand("SELECT COUNT(*) from felhasznalok where Felh_nev = @felh",con);
            com.Parameters.AddWithValue("@felh", _username);
            com.ExecuteNonQuery();
            int result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();

            return result;
        }

       

        internal static void Regisztacio(string _username, string _pass, int _select)
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"INSERT INTO felhasznalok(Felh_nev, Jelszo, Jog) Values(@felh, @Jelszo, @jog)",con);
            com.Parameters.AddWithValue("@felh", _username);
            com.Parameters.AddWithValue("@Jelszo", Seged.HASH_jelszo(_pass));
            com.Parameters.AddWithValue("@jog", _select.ToString());
            com.ExecuteNonQuery();
            MessageBox.Show($"{_username} Felhasználó regisztrálva!");
            con.Close();
        }

        

        internal static int Mester_Kulcs(string _pass)
        {
            con.Open();

            SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM felhasznalok WHERE Felh_nev = 'Admin' and Jelszo = @jelszo",con);
            com.Parameters.AddWithValue("@jelszo", Seged.HASH_jelszo(_pass));
            com.ExecuteNonQuery();
            int result = Convert.ToInt32(com.ExecuteScalar());

            con.Close();
            return result;
        }

        




        #endregion Regisztracio
        #region Beszallítók
        internal static DataTable Beszallitok_Betoltese()
        {
            
            con.Open();

            SqlDataAdapter data = new SqlDataAdapter("Select * from beszallitok",con);
            DataTable result = new DataTable();
            data.Fill(result);

            con.Close();

            return result;
        }
        internal static void Beszallitok_felvetele(string _cnev, string _orszag, string _irszam, string _varos, string _cim, string _telefon)
        {
            con.Open();

            SqlCommand com = new SqlCommand("insert into beszallitok (Nev,Orszag,Iranyitosz,Város,Cim,Telsz) values (@Nev,@Orszag,@Iranyitosz,@varos,@Cim,@Telsz)",con);
            com.Parameters.AddWithValue("@Nev", _cnev);
            com.Parameters.AddWithValue("@Orszag", _orszag);
            com.Parameters.AddWithValue("@Iranyitosz", Convert.ToInt32(_irszam));
            com.Parameters.AddWithValue("@varos", _varos);
            com.Parameters.AddWithValue("@Cim", _cim);
            com.Parameters.AddWithValue("@Telsz", _telefon);
            com.ExecuteNonQuery();
            MessageBox.Show($"{_cnev} sikeresen hozzáadva.");
            con.Close();
        }
        internal static int Beszallito_Validalas(string _cnev)
        {
            con.Open();

            SqlCommand com = new SqlCommand("select count(*) from beszallitok where Nev = @nev",con);
            com.Parameters.AddWithValue("@nev", _cnev);
            com.ExecuteNonQuery();
            int result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return result;
        }
        internal static void Beszallito_Szerkesztes(string _cnev, string _orszag, string _irszam, string _varos, string _cim, string _telefon,int _beszID)
        {
            con.Open();

            SqlCommand com = new SqlCommand("update beszallitok set Nev=@nev,Orszag=@or,Iranyitosz=@ir,Város=@varos,Cim=@cim,Telsz=@tel where BeszallitoID = @id", con);
            com.Parameters.AddWithValue("@nev", _cnev);
            com.Parameters.AddWithValue("@or", _orszag);
            com.Parameters.AddWithValue("@ir", Convert.ToInt32(_irszam));
            com.Parameters.AddWithValue("@varos", _varos);
            com.Parameters.AddWithValue("@cim", _cim);
            com.Parameters.AddWithValue("@tel", _telefon);
            com.Parameters.AddWithValue("@id", _beszID);
            com.ExecuteNonQuery();
            MessageBox.Show($"{_cnev} adatai módosítva!");
            con.Close();
        }

        




        #endregion Beszallítók
        #region Jegyzet
        internal static void Jegyzet_Hozzaadas(string _jnev, string _jtext)
        {
            con.Open();

            SqlCommand com = new SqlCommand("insert into jegyzet (FelhasznaloID,Jegyzetnev,Szoveg,Datum)" +
                "values (@felid,@jegyzetnev,@szoveg,@datum)",con);
            com.Parameters.AddWithValue("@felid", Login.UserID);
            com.Parameters.AddWithValue("@jegyzetnev", _jnev);
            com.Parameters.AddWithValue("@szoveg",_jtext);
            com.Parameters.AddWithValue("@datum", DateTime.Now);
            com.ExecuteNonQuery();
            MessageBox.Show("Sikeresen hozzáadva!");
            con.Close();
        } 
        internal static int Jegyzet_Validalas(string _jnev)
        {
            con.Open();

            SqlCommand com = new SqlCommand("select count(*) from jegyzet where Jegyzetnev = @nev", con);
            com.Parameters.AddWithValue("@nev", _jnev);
            com.ExecuteNonQuery();
            int result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();

            return result;
        }
        internal static DataTable Jegyzet_Feltoltes()
        {
            con.Open();

            SqlDataAdapter data = new SqlDataAdapter("select f.ID,f.Felh_nev as Felhasználónév,j.Jegyzetnev as Jegyzetnév," +
                "j.Szoveg,j.Datum from jegyzet j left join felhasznalok f on j.FelhasznaloID = f.ID where f.ID ='" + Login.UserID + "'",con);

            DataTable result = new DataTable();
            data.Fill(result);
            con.Close();
            return result;
        }
        internal static void Jegyzet_Torles(string _jnev)
        {
            con.Open();

            SqlCommand com = new SqlCommand("delete from jegyzet where Jegyzetnev = '" + _jnev + "' and FelhasznaloID = '" + Login.UserID + "'",con);
            com.ExecuteNonQuery();
            MessageBox.Show($"{_jnev} Törölve");
            con.Close();
        }
        #endregion Jegyzet
        #region RaktatTörtenet
        internal static DataTable Raktartortenet()
        {
            con.Open();

            SqlDataAdapter com = new SqlDataAdapter("SELECT r.Felhasznalo as Felhasználó,r.Cselekmeny as Cselekmény,r.Datum as Dátum FROM raktartortenet r", Seged.con);
            DataTable result = new DataTable();
            com.Fill(result);
            con.Close();
            return result;
        }

        internal static DataTable Kiadott_termekek()
        {
            con.Open();

            SqlDataAdapter com = new SqlDataAdapter("select t.VevoNev as 'Vevő Neve',t.TermekNev as 'Termék neve',t.TermekAr as 'Termék DB ár'," +
                "t.Darab as 'Kiadott Mennyiség',t.OsszesenAr as 'Ár Összesen',t.Datum as Dátum from kiadott_termekek t",con);
            DataTable result = new DataTable();
            com.Fill(result);
           
            con.Close();
            return result;
        }

        internal static DataTable Elfogyott_termek()
        {
            con.Open();

            SqlDataAdapter com = new SqlDataAdapter("SELECT t.Termeknev as Terméknév,t.Cikkszam as Cikkszám,t.Keszlet as Készlet," +
                "t.Ar as Ár,k.katNev as Kategórianév from termekek t left join kategoria k on t.KategoriaId = k.kategoriaID where t.Keszlet ='0'", con);
            DataTable  result = new DataTable();
            com.Fill(result);
            
            con.Close();
            return result;
        }
        internal static void Raktartortenet_torles()
        {
            con.Open();

            SqlCommand com = new SqlCommand("Delete FROM raktartortenet where 1=1", con);
            com.ExecuteNonQuery();
            MessageBox.Show("Adatok Törölve!");
            con.Close();
        }
        #endregion RaktarTörténet
        #region TermekKereses
        internal static DataTable Termekkeres_KategotiaCombobox_Feltoltes()
        {
            con.Open();
            SqlDataAdapter data = new SqlDataAdapter("Select k.katNev from kategoria k",con);
            DataTable result = new DataTable();
            data.Fill(result);
            con.Close();
            return result;
        }
        internal static DataTable TermekKeres_TermekFeltoltes()
        {
            con.Open();
            SqlDataAdapter dat = new SqlDataAdapter("Select t.TermekNev,t.Cikkszam,t.Keszlet,t.Ar,k.katNev as " +
                "Kategória from termekek t left join kategoria k on t.KategoriaID = k.kategoriaID",con);
            DataTable result = new DataTable();
            dat.Fill(result); 
            con.Close();
            return result;
        }
        #endregion TermekKereses
        #region TermekFelvétel
        internal static int BeszallitoCombo(string _s)
        {
            int result = 0;
            con.Open();
            SqlCommand com = new SqlCommand("Select b.BeszallitoID from beszallitok b where Nev = @bnev",con);
            com.Parameters.AddWithValue("@bnev",_s);
            com.ExecuteNonQuery();
            result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();

            return result;
        }
        internal static int KatComboSelect(object _k)
        {
            int result = 0;
            con.Open();
            SqlCommand com = new SqlCommand("Select k.kategoriaID from kategoria k where katNev = @knev", con);
            com.Parameters.AddWithValue("@knev", _k);
            com.ExecuteNonQuery();
            result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();

            return result;
        }
        internal static DataTable Termek_BeszallitoCombo_Feltoltes()
        {
            con.Open();

            SqlDataAdapter data = new SqlDataAdapter("SELECT Nev FROM beszallitok", con);
            DataTable result = new DataTable();
            data.Fill(result);
            con.Close();
            return result;
        }
       
        internal static void TermekFelvetel_Keppel(int _combokat, string _tnev, string _tcikksz, string _tkeszlet, string _tar, Image _termekkep, Image _qrkep, int _combobesz)
        {
            con.Open();

            SqlCommand com = new SqlCommand(@"INSERT INTO termekek (KategoriaID,TermekNev,Cikkszam,Keszlet,Ar,Kep,QrCode,BeszallitoID) VALUES (@katID,@nev,@cikk,@keszlet,@ar,@tkep,@qr,@beid)",con);
            com.Parameters.AddWithValue("@katID", _combokat);
            com.Parameters.AddWithValue("@nev", _tnev);
            com.Parameters.AddWithValue("@cikk", _tcikksz);
            com.Parameters.AddWithValue("@keszlet", Convert.ToInt32(_tkeszlet));
            com.Parameters.AddWithValue("@ar", Convert.ToInt32(_tar));
            com.Parameters.AddWithValue("@tkep", Kep_to_Byte(_termekkep));
            com.Parameters.AddWithValue("@qr", Kep_to_Byte(_qrkep));
            com.Parameters.AddWithValue("@beid", _combobesz);
            com.ExecuteNonQuery();

            con.Close();
        } 
        internal static void TermekFelvetel_Kepnelkul(int _combokat, string _tnev, string _tcikksz, string _tkeszlet, string _tar, Image _qrkep, int _combobesz)
        {
            con.Open();

            SqlCommand com = new SqlCommand(@"INSERT INTO termekek (KategoriaID,TermekNev,Cikkszam,Keszlet,Ar,QrCode,BeszallitoID) VALUES (@katID,@nev,@cikk,@keszlet,@ar,@qr,@beid)", con);
            com.Parameters.AddWithValue("@katID", _combokat);
            com.Parameters.AddWithValue("@nev", _tnev);
            com.Parameters.AddWithValue("@cikk", _tcikksz);
            com.Parameters.AddWithValue("@keszlet", Convert.ToInt32(_tkeszlet));
            com.Parameters.AddWithValue("@ar", Convert.ToInt32(_tar));
            com.Parameters.AddWithValue("@qr", Kep_to_Byte(_qrkep));
            com.Parameters.AddWithValue("@beid", _combobesz);
            com.ExecuteNonQuery();

            con.Close();
        }
        public static byte[] Kep_to_Byte(Image _img)
        {
            byte[] result;

            ImageConverter converter = new ImageConverter();
            result = (byte[])converter.ConvertTo(_img, typeof(byte[]));

            return result;
        }
        internal static int Termek_Ellenorzes(string _tnev, string _cikkszam)
        {
            con.Open();

            SqlCommand com = new SqlCommand("select count(*) from termekek where TermekNev =@nev or Cikkszam = @cikk", con);
            com.Parameters.AddWithValue("@nev", _tnev);
            com.Parameters.AddWithValue("@cikk", _cikkszam);
            com.ExecuteNonQuery();
            int result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return result;
        }

        #endregion TermekFelvétel
        #region TermekKiadas
        internal static DataTable TermekKiadas_Termekfeltoltes()
        {
            con.Open();
            SqlDataAdapter termek = new SqlDataAdapter("select t.TermekID,t.TermekNev as Terméknév,t.Ar as Ár,t.Keszlet as Készleten from termekek t where t.Keszlet > '0'",con);
            DataTable result = new DataTable();
            termek.Fill(result);
            con.Close();
            return result;
            
        }
        internal static object TermekKiadas_VevoFeltoltes()
        {
            con.Open();
            SqlDataAdapter vevo = new SqlDataAdapter("select v.VevoID,v.Nev,v.Orszag from vevok v", con);
            DataTable result = new DataTable();
            vevo.Fill(result);
            con.Close();
            return result;
        }
        internal static void KeszletModositas(int _marad, int _termekID)
        {
            con.Open();

            SqlCommand com = new SqlCommand("update termekek set Keszlet = @keszlet where TermekID = @id",con);
            com.Parameters.AddWithValue("@keszlet", _marad);
            com.Parameters.AddWithValue("@id", _termekID);
            com.ExecuteNonQuery();
            con.Close();
        }
        internal static void TermekKiad_Kiadott_Termekek(int vevoid, string _vnev, string _tnev, string _tar, string _tkell, int osszeg)
        {
            con.Open();
            SqlCommand com = new SqlCommand("insert into kiadott_termekek (VevoID,VevoNev,TermekNev,TermekAr,Darab,OsszesenAr,Datum)" +
                            "Values (@vevoid,@vevonev,@termeknev,@ar,@darab,@ossz,@datum)",con);
            com.Parameters.AddWithValue("@vevoid", vevoid);
            com.Parameters.AddWithValue("@vevonev", _vnev);
            com.Parameters.AddWithValue("@termeknev", _tnev);
            com.Parameters.AddWithValue("@ar", Convert.ToInt32(_tar));
            com.Parameters.AddWithValue("@darab", Convert.ToInt32(_tkell));
            com.Parameters.AddWithValue("@ossz", osszeg);
            com.Parameters.AddWithValue("@datum", DateTime.Now);
            com.ExecuteNonQuery();
            con.Close();
        }
        #endregion TermekKiadas
        #region TermekTörles
        internal static DataTable TermekTorles_TermekFeltoltes()
        {
            con.Open();
            SqlDataAdapter dat = new SqlDataAdapter("select t.TermekId,t.TermekNev,t.Cikkszam,t.Keszlet,t.Ar,k.katNev as Kategória," +
                "be.Nev as Beszállító from termekek t left join kategoria k on" +
                " t.KategoriaID = k.kategoriaID left join beszallitok be on t.BeszallitoID = be.BeszallitoID",con);
            DataTable result = new DataTable();
            dat.Fill(result);
            con.Close();
            return result;
        } 
        internal static void TErmekTorol_Szerkesztes_Keppel(string _tnev, string _tcikk, string _tkeszlet, string _tar, Image _timage, Image _qrimage, int _termID)
        {
            con.Open();

            SqlCommand com = new SqlCommand("update termekek set TermekNev = @nev,Cikkszam = @cikk,Keszlet = @keszlet,Ar = @ar,Kep = @kep,QrCode = @qr where TermekID = @id",con);
            com.Parameters.AddWithValue("@nev", _tnev);
            com.Parameters.AddWithValue("@cikk", _tcikk);
            com.Parameters.AddWithValue("@keszlet", Convert.ToInt32(_tkeszlet));
            com.Parameters.AddWithValue("@ar", Convert.ToInt32(_tar));
            com.Parameters.AddWithValue("@kep", Kep_to_Byte(_timage));
            com.Parameters.AddWithValue("@qr", Kep_to_Byte(_qrimage));
            com.Parameters.AddWithValue("id", _termID);
            com.ExecuteNonQuery(); 
            con.Close();
        }
        internal static void Termektotol_Szerkesztes_kepnelkul(string _tnev, string _tcikk, string _tkeszlet, string _tar, Image _qrimage, int _termID)
        {
            con.Open();

            SqlCommand com = new SqlCommand("update termekek set TermekNev = @nev,Cikkszam = @cikk,Keszlet = @keszlet,Ar = @ar,QrCode = @qr where TermekID = @id",con);
            com.Parameters.AddWithValue("@nev", _tnev);
            com.Parameters.AddWithValue("@cikk", _tcikk);
            com.Parameters.AddWithValue("@keszlet", Convert.ToInt32(_tkeszlet));
            com.Parameters.AddWithValue("@ar", Convert.ToInt32(_tar));
            com.Parameters.AddWithValue("@qr", Kep_to_Byte(_qrimage));
            com.Parameters.AddWithValue("id", _termID);
            com.ExecuteNonQuery();
            MessageBox.Show("Termék modosítva!");

            con.Close();
        }
        internal static void TermekTorol_Torol(int _termID)
        {
            con.Open();

            SqlCommand com = new SqlCommand("DELETE FROM termekek where TermekID = @id",con);
            com.Parameters.AddWithValue("@id", _termID);
            com.ExecuteNonQuery();
            con.Close();
        }
        #endregion TermekTörles
        #region VevőkKeresése
        internal static object VevoKeres_VevokFeltoltes()
        {
            con.Open();

            SqlDataAdapter data = new SqlDataAdapter("SELECT v.VevoId as VevőID,v.Nev,v.Orszag,v.Iranyitosz as Irányítószám,v.Cim,v.Telsz as Telefonszám FROM vevok v",con);
            DataTable result = new DataTable();
            data.Fill(result); 
            con.Close();
            return result;
        } 
        internal static void VevoKeres_VevokFelvetete(string _nev, string _orszag, string _irszam, string _cim, string _telefonszam)
        {
            con.Open();

            SqlCommand com = new SqlCommand("insert into vevok (Nev,Orszag,Iranyitosz,Cim,Telsz) values (@nev,@orszag,@iranysz,@cim,@telsz)",con);
            com.Parameters.AddWithValue("@nev", _nev);
            com.Parameters.AddWithValue("@orszag", _orszag);
            com.Parameters.AddWithValue("@iranysz", Convert.ToInt32(_irszam));
            com.Parameters.AddWithValue("@cim", _cim);
            com.Parameters.AddWithValue("@telsz", _telefonszam);
            com.ExecuteNonQuery(); 
            con.Close();
        }
        internal static int VevoKeres_Vevok_Validacio(string _nev,string _cim)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select count(*) from vevok where Nev = @nev and Cim = @cim ", con);
            com.Parameters.AddWithValue("@nev", _nev);
            com.Parameters.AddWithValue("@cim", _cim);
            com.ExecuteNonQuery();
            int result = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return result;
        }

        #endregion VevőkKeresése
        #region VevőkTörlése
        internal static void VevoTorles(int _publikID)
        {
            con.Open();

            SqlCommand com = new SqlCommand("DELETE from vevok where VevoID = @id",con);
            com.Parameters.AddWithValue("@id", _publikID);
            com.ExecuteNonQuery();

            con.Close();

        }
        internal static void Vevoszerkesztes(string _nev, string _orszag, string _irszam, string _cim, string _telefonszam, int publikID)
        {
            con.Open();

            SqlCommand com = new SqlCommand("UPDATE vevok set Nev = @nev,Orszag = @orszag,Iranyitosz = @irsz,Cim = @cim,Telsz =@telsz where VevoID = @id ", con);
            com.Parameters.AddWithValue("@nev", _nev);
            com.Parameters.AddWithValue("@orszag", _orszag);
            com.Parameters.AddWithValue("@irsz", Convert.ToInt32(_irszam));
            com.Parameters.AddWithValue("@cim", _cim);
            com.Parameters.AddWithValue("@telsz", _telefonszam);
            com.Parameters.AddWithValue("@id", publikID);
            com.ExecuteNonQuery();
            con.Close();
        }
        #endregion VevőkTörlése
        #region Kitöltés_ellenörzés
        internal static bool Tx_Box_text_hossz(string _t1,string _t2,string _t3,string _t4)
        {
            bool result;
            if (_t1.Length <= 50 && _t2.Length <=50 && _t3.Length<=50 && _t4.Length<=50)
            {
                result = true;
            }
            else result = false;

            return result;
        }
        
        internal static bool TX_Box_szam_3(string _t1, string _t2, string _t3)
        {
            bool result;

            if (System.Text.RegularExpressions.Regex.IsMatch(_t1, "[0-9]") && System.Text.RegularExpressions.Regex.IsMatch(_t2, "[0-9]")
                && System.Text.RegularExpressions.Regex.IsMatch(_t3, "[0-9]") && !System.Text.RegularExpressions.Regex.IsMatch(_t1, "[|,|.|+|-|]")
                && !System.Text.RegularExpressions.Regex.IsMatch(_t2, "[|,|.|+|-|]") && !System.Text.RegularExpressions.Regex.IsMatch(_t3, "[|,|.|+|-|]"))
            {
                result = true;
            }
            else result = false;

            return result;
        }
        #endregion
    }
}
