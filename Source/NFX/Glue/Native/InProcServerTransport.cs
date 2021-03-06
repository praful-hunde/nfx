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

using NFX.Glue.Protocol;

namespace NFX.Glue.Native
{
    /// <summary>
    /// Provides server-side functionality for synchronous communication pattern based on
    ///  in-memory message exchange without serialization
    /// </summary>
    public class InProcServerTransport : ServerTransport<InProcBinding>
    {
        #region .ctor

           public InProcServerTransport(InProcBinding binding, ServerEndPoint serverEndpoint) : base(binding, serverEndpoint)
           {
             Node = serverEndpoint.Node;
           }

        #endregion

        #region Fields/Props

        #endregion

        #region Protected

            protected override bool DoSendResponse(ResponseMsg response)
            {
              throw new InvalidGlueOperationException(StringConsts.OPERATION_NOT_SUPPORTED_ERROR + GetType().FullName+".SendResponse()");
            }

        #endregion
    }
}
