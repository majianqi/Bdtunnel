/* BoutDuTunnel Copyright (c) 2007-2010 Sebastien LEBRETON

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. */

#region " Inclusions "
using System;
#endregion

namespace Bdt.Shared.Response
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// Une connexion au sein du tunnel
    /// </summary>
    /// -----------------------------------------------------------------------------
    [Serializable]
    public struct Connection 
    {

        #region " Proprietes "

	    /// -----------------------------------------------------------------------------
	    /// <summary>
	    /// Le nombre d'octets lus
	    /// </summary>
	    /// -----------------------------------------------------------------------------
	    public int ReadCount { get; set; }

	    /// -----------------------------------------------------------------------------
	    /// <summary>
	    /// Le nombre d'octets �crits
	    /// </summary>
	    /// -----------------------------------------------------------------------------
	    public int WriteCount { get; set; }

	    /// -----------------------------------------------------------------------------
	    /// <summary>
	    /// L'adresse distante
	    /// </summary>
	    /// -----------------------------------------------------------------------------
	    public string Address { get; set; }

	    /// -----------------------------------------------------------------------------
	    /// <summary>
	    /// Le h�te distant
	    /// </summary>
	    /// -----------------------------------------------------------------------------
	    public string Host { get; set; }

	    /// -----------------------------------------------------------------------------
	    /// <summary>
	    /// Le port distant
	    /// </summary>
	    /// -----------------------------------------------------------------------------
	    public int Port { get; set; }

	    /// -----------------------------------------------------------------------------
	    /// <summary>
	    /// La date de dernier acc�s
	    /// </summary>
	    /// -----------------------------------------------------------------------------
	    public DateTime LastAccess { get; set; }

	    /// -----------------------------------------------------------------------------
	    /// <summary>
	    /// Le jeton de connexion
	    /// </summary>
	    /// -----------------------------------------------------------------------------
	    public string Cid { get; set; }

	    #endregion

    }

}
