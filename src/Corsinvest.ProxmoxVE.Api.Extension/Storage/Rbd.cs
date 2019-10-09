﻿/*
 * This file is part of the cv4pve-api-dotnet https://github.com/Corsinvest/cv4pve-api-dotnet,
 * Copyright (C) 2016 Corsinvest Srl
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Corsinvest.ProxmoxVE.Api.Extension.Helpers;

namespace Corsinvest.ProxmoxVE.Api.Extension.Storage
{
    /// <summary>
    /// Rbd storage
    /// </summary>
    public class Rbd : StorageInfo
    {
        internal Rbd(PveClient client, object apiData) : base(client, apiData, StorageTypeEnum.Rbd)
        {
            DynamicHelper.CheckKeyOrCreate(apiData, "monhost", "");
        }

        /// <summary>
        /// Pool
        /// </summary>
        public string Pool => ApiData.pool;

        /// <summary>
        /// Monitor hosts
        /// </summary>
        public string MonitorHosts => ApiData.monhost;

        /// <summary>
        /// Username
        /// </summary>
        public string Username => ApiData.username;

        /// <summary>
        /// Krbb
        /// </summary>
        public bool Krbd => ApiData.krbd == "1";
    }
}