﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Testing_Job
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Testing_JobRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("883c7980-d37a-4777-b2a4-7ad6e7058c00")]
    public partial class Testing_JobRepository : RepoGenBaseFolder
    {
        static Testing_JobRepository instance = new Testing_JobRepository();
        Testing_JobRepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the Testing_JobRepository element repository.
        /// </summary>
        [RepositoryFolder("883c7980-d37a-4777-b2a4-7ad6e7058c00")]
        public static Testing_JobRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Testing_JobRepository() 
            : base("Testing_JobRepository", "/", null, 0, false, "883c7980-d37a-4777-b2a4-7ad6e7058c00", ".\\RepositoryImages\\Testing_JobRepository883c7980.rximgres")
        {
            _rxmainframe = new Testing_JobRepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("883c7980-d37a-4777-b2a4-7ad6e7058c00")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("8a791b50-6f95-48b7-9a8c-6bd886407552")]
        public virtual Testing_JobRepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Testing_JobRepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("8a791b50-6f95-48b7-9a8c-6bd886407552")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _btnsubmitusernameInfo;
            RepoItemInfo _rxbuttonexitInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@automationid='RxMainFrame']", parentFolder, 30000, null, true, "8a791b50-6f95-48b7-9a8c-6bd886407552", "")
            {
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/tabpage[@automationid='RxTabIntroduction']/?/?/text[@accessiblename='Enter your name']", ".//text[@accessiblename='Enter your name']", 30000, null, "de59b882-de9a-4c1d-9e8b-e0145ff984b0");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@automationid='RxTabIntroduction']/button[@text='Submit']", ".//button[@text='Submit']", 30000, null, "15fb0917-0850-4383-84ea-f3d8ceaadf54");
                _rxbuttonexitInfo = new RepoItemInfo(this, "RxButtonExit", "button[@text='E&xit']", "button[@text='E&xit']", 30000, null, "a814612c-4d40-4172-ba9b-1dea92a7eb1a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("8a791b50-6f95-48b7-9a8c-6bd886407552")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("8a791b50-6f95-48b7-9a8c-6bd886407552")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("de59b882-de9a-4c1d-9e8b-e0145ff984b0")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("de59b882-de9a-4c1d-9e8b-e0145ff984b0")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("15fb0917-0850-4383-84ea-f3d8ceaadf54")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("15fb0917-0850-4383-84ea-f3d8ceaadf54")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }

            /// <summary>
            /// The RxButtonExit item.
            /// </summary>
            [RepositoryItem("a814612c-4d40-4172-ba9b-1dea92a7eb1a")]
            public virtual Ranorex.Button RxButtonExit
            {
                get
                {
                    return _rxbuttonexitInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The RxButtonExit item info.
            /// </summary>
            [RepositoryItemInfo("a814612c-4d40-4172-ba9b-1dea92a7eb1a")]
            public virtual RepoItemInfo RxButtonExitInfo
            {
                get
                {
                    return _rxbuttonexitInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
