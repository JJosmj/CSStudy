﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  UpDate 실습하기
 * 
 */
namespace Ch10
{
    internal class _3_UpDate_실습
    {
        static void Main1(string[] args)
        {
            //데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";

            //데이터베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            //데이터베이서 접속
            try
            {
                //접속
                conn.Open();
                Console.WriteLine("접속 성공");

                //SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `user1` SET `hp`='010-1234-1111',`age` = 28 WHERE `uid`='c101'";
                cmd.ExecuteNonQuery();

                Console.WriteLine("SQL 완료");
            }
            catch (Exception e)
            {
                Console.WriteLine("접속 실패: " + e.Message);
            }
            finally
            {
                //접속 종료
                conn.Close();
                Console.WriteLine("접속 종료");
            }
        }
    }
}
