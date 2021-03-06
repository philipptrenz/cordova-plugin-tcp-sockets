﻿/**
 * Copyright (c) 2015, Blocshop s.r.o.
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms are permitted
 * provided that the above copyright notice and this paragraph are
 * duplicated in all such forms and that any documentation,
 * advertising materials, and other materials related to such
 * distribution and use acknowledge that the software was developed
 * by the Blocshop s.r.o.. The name of the
 * Blocshop s.r.o. may not be used to endorse or promote products derived
 * from this software without specific prior written permission.
 * THIS SOFTWARE IS PROVIDED ``AS IS'' AND WITHOUT ANY EXPRESS OR
 * IMPLIED WARRANTIES, INCLUDING, WITHOUT LIMITATION, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.
 */

using System.Runtime.Serialization;

namespace Blocshop.ScoketsForCordova
{
    [DataContract]
    internal abstract class SocketServerEvent
    {
        [DataMember(Name = "type")]
        public abstract string Type { get; set; }

        [DataMember(Name = "serverSocketKey")]
        public string ServerSocketKey { get; set; }
    }

    [DataContract]
    internal class ConnectedSocketServerEvent : SocketServerEvent
    {
        [DataMember(Name = "type")]
        public override string Type
        {
            get
            {
                return "Connected";
            }
            set
            {
            }
        }

        [DataMember(Name = "socketKey")]
        public string SocketKey { get; set; }
    }

    [DataContract]
    internal class StoppedSocketServerEvent : SocketServerEvent
    {
        public override string Type
        {
            get
            {
                return "Stopped";
            }
            set
            {
            }
        }

        [DataMember(Name = "hasError")]
        public bool HasError { get; set; }
    }
}
