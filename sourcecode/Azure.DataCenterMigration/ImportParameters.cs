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
namespace Azure.DataCenterMigration
{
    /// <summary>
    /// Class to store input parameters value for Import functionality.
    /// </summary>
    internal class ImportParameters : BaseParameters
    {        
        public string DestinationDCName { get; set; }

        public string ImportMetadataFilePath { get; set; }

        public string MapperXmlFilePath { get; set; }

        public string DestinationPrefixName { get; set; }

        public bool RollBackOnFailure { get; set; }

        public bool ResumeImport { get; set; }

        public PublishSetting DestinationSubscriptionSettings { get; set; }

        public PublishSetting SourceSubscriptionSettings { get; set; }
    }
}
