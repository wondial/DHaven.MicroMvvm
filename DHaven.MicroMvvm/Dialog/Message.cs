﻿#region Copyright 2016 D-Haven.org

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DHaven.MicroMvvm.Dialog
{
    public class Message : ObservableObject
    {
        public Message() { }

        public Message(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public string Title
        {
            get { return GetValue<string>(nameof(Title)); }
            set { SetValue(nameof(Title), value); }
        }

        public string Content
        {
            get { return GetValue<string>(nameof(Content)); }
            set { SetValue(nameof(Content), value); }
        }
    }
}