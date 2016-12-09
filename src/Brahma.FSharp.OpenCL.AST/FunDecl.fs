﻿// Copyright (c) 2012, 2013 Semyon Grigorev <rsdpisuy@gmail.com>
// All rights reserved.
// 
// The contents of this file are made available under the terms of the
// Eclipse Public License v1.0 (the "License") which accompanies this
// distribution, and is available at the following URL:
// http://www.opensource.org/licenses/eclipse-1.0.php
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either expressed or implied. See the License for
// the specific language governing rights and limitations under the License.
// 
// By using this software in any fashion, you are agreeing to be bound by the
// terms of the License.

namespace Brahma.FSharp.OpenCL.AST

type FunFormalArg<'lang>(isGlobal:bool, name:string, _type:Type<'lang>) =
    inherit Statement<'lang>()
    override this.Children = []
    member this.IsGlobal = isGlobal
    member this.Name = name
    member this.Type = _type

type FunDecl<'lang>(isKernel:bool, name:string, retType:Type<'lang>, args:List<FunFormalArg<'lang>>, body:Statement<'lang>) =
    inherit TopDef<'lang>()
    override this.Children = []
    member this.isKernel = isKernel 
    member this.RetType = retType
    member this.Name = name
    member this.Args = args
    member this.Body = body

