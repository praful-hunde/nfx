/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2018 Agnicore Inc. portions ITAdapter Corp. Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX;
using NFX.Security;

namespace NFX.Web.Shipping.Shippo
{
  public class ShippoCredentials : Credentials
  {
    public ShippoCredentials(string privateToken, string publicToken)
    {
      PrivateToken = privateToken;
      PublicToken = publicToken;
    }

    public readonly string PrivateToken;
    public readonly string PublicToken;

    public override string ToString()
    {
      return "[{0} {1}]".Args(PrivateToken, PublicToken);
    }
  }
}
