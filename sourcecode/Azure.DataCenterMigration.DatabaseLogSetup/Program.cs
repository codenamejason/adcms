﻿/*******************************************************************************
 * Copyright 2014 Persistent Systems Ltd.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 ******************************************************************************/
using System;
using System.Threading;
using System.Windows.Forms;

namespace Azure.DataCenterMigration.DatabaseLogSetup
{
    /// <summary>
    /// This class uses entity framework for creating database required for SQL logging
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This method invokes the LoggingContext() that creates a context for database logging
        /// and also invokes DataCenterLog() that creates a table to store log values
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Constants.ConnectingToSqlServer);
                var database = new LoggingContext();
                var dblog = new DataCenterLog();
                database.logs.Add(dblog);
                Console.WriteLine(Constants.SuccessfulConnection);
                Thread.Sleep(2000);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
