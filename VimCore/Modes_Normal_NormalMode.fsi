﻿#light

namespace Vim.Modes.Normal
open Vim
open Microsoft.VisualStudio.Text
open Microsoft.VisualStudio.Text.Editor

type internal NormalMode =
    interface INormalMode
    new: (IVimBuffer* IOperations * IIncrementalSearch) -> NormalMode
    member IncrementalSearch : IIncrementalSearch

