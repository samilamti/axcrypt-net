﻿#region Coypright and License

/*
 * AxCrypt - Copyright 2012, Svante Seleborg, All Rights Reserved
 *
 * This file is part of AxCrypt.
 *
 * AxCrypt is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * AxCrypt is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with AxCrypt.  If not, see <http://www.gnu.org/licenses/>.
 *
 * The source is maintained at http://bitbucket.org/axantum/axcrypt-net please visit for
 * updates, contributions and contact with the author. You may also visit
 * http://www.axantum.com for more information about the author.
*/

#endregion Coypright and License

using System;
using System.Runtime.Serialization;

namespace Axantum.AxCrypt.Core.Runtime
{
    [Serializable]
    public class InvalidDataException : AxCryptException
    {
        public InvalidDataException()
            : base()
        {
        }

        public InvalidDataException(string message)
            : this(message, ErrorStatus.DataError)
        {
        }

        public InvalidDataException(string message, ErrorStatus errorStatus)
            : base(message, errorStatus)
        {
        }

        protected InvalidDataException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public InvalidDataException(string message, Exception innerException)
            : this(message, ErrorStatus.DataError, innerException)
        {
        }

        public InvalidDataException(string message, ErrorStatus errorStatus, Exception innerException)
            : base(message, errorStatus, innerException)
        {
        }
    }
}