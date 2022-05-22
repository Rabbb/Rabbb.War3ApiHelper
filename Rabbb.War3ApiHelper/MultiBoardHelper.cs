// ------------------------------------------------------------------------------
// <copyright file="MultiBoardExtension.cs" company="Rabbb">
// Copyright (c) 2022 Rabbb. All rights reserved.
// Licensed under the MPL-2.0 license. See LICENSE file in the project root for full license information.
// </copyright>
// ------------------------------------------------------------------------------

#pragma warning disable IDE0052, IDE1006, CS0626
#pragma warning disable CA1034, CA1707, CA1716, CA2211,
#pragma warning disable SA1028, SA1124, SA1200, SA1201, SA1202, SA1203, SA1300, SA1303, SA1307, SA1310, SA1311, SA1313, SA1314, SA1401, SA1407, SA1507, SA1514, SA1516, SA1600, SA1601, SA1604, SA1611, SA1615, SA1623, SA1626

#if DEBUG

using Rabbb.War3Api;
using hashtable = Rabbb.War3Api.Common.hashtable;
using multiboard = Rabbb.War3Api.Common.multiboard;
using multiboarditem = Rabbb.War3Api.Common.multiboarditem;

#else
using War3Api;
using hashtable = War3Api.Common.hashtable;
using multiboard = War3Api.Common.multiboard;
using multiboarditem = War3Api.Common.multiboarditem;

#endif

namespace Rabbb.War3ApiHelper
{
    /// <summary>
    /// 多面板助手.
    /// </summary>
    public static partial class MultiBoardHelper
    {
        #region Common

        /// <summary>创建多面板.</summary>
        public static multiboard Create() => Common.CreateMultiboard();

        /// <summary>销毁多面板.</summary>
        public static void Destroy(this multiboard lb) => Common.DestroyMultiboard(lb);

        /// <summary>显示/隐藏多面板.</summary>
        public static void Display(this multiboard lb, bool show) => Common.MultiboardDisplay(lb, show);

        /// <summary>是已显示多面板.</summary>
        public static bool IsDisplayed(this multiboard lb) => Common.IsMultiboardDisplayed(lb);

        /// <summary>最小化多面板.</summary>
        public static void Minimize(this multiboard lb, bool minimize) => Common.MultiboardMinimize(lb, minimize);

        /// <summary>是已最小化多面板.</summary>
        public static bool IsMinimized(this multiboard lb) => Common.IsMultiboardMinimized(lb);

        /// <summary>清空多面板.</summary>
        public static void Clear(this multiboard lb) => Common.MultiboardClear(lb);

        /// <summary>设置多面板的标题.</summary>
        public static void SetTitleText(this multiboard lb, string label) => Common.MultiboardSetTitleText(lb, label);

        /// <summary>获取多面板的标题.</summary>
        public static string GetTitleText(this multiboard lb) => Common.MultiboardGetTitleText(lb);

        /// <summary>设置多面板的标题颜色.</summary>
        public static void SetTitleTextColor(this multiboard lb, int red, int green, int blue, int alpha) => Common.MultiboardSetTitleTextColor(lb, red, green, blue, alpha);

        /// <summary>获取多面板的行数.</summary>
        public static int GetRowCount(this multiboard lb) => Common.MultiboardGetRowCount(lb);

        /// <summary>获取多面板的列数.</summary>
        public static int GetColumnCount(this multiboard lb) => Common.MultiboardGetColumnCount(lb);

        /// <summary>设置多面板的列数.</summary>
        public static void SetColumnCount(this multiboard lb, int count) => Common.MultiboardSetColumnCount(lb, count);

        /// <summary>设置多面板的行数.</summary>
        public static void SetRowCount(this multiboard lb, int count) => Common.MultiboardSetRowCount(lb, count);

        /// <summary>设置多面板的项目风格(显示 值, 图标).</summary>
        public static void SetItemsStyle(this multiboard lb, bool showValues, bool showIcons) => Common.MultiboardSetItemsStyle(lb, showValues, showIcons);

        /// <summary>设置多面板的项目值.</summary>
        public static void SetItemsValue(this multiboard lb, string value) => Common.MultiboardSetItemsValue(lb, value);

        /// <summary>设置多面板的项目值颜色.</summary>
        public static void SetItemsValueColor(this multiboard lb, int red, int green, int blue, int alpha) => Common.MultiboardSetItemsValueColor(lb, red, green, blue, alpha);

        /// <summary>设置多面板的项目宽度.</summary>
        public static void SetItemsWidth(this multiboard lb, float width) => Common.MultiboardSetItemsWidth(lb, width);

        /// <summary>设置多面板的项目图标.</summary>
        public static void SetItemsIcon(this multiboard lb, string iconPath) => Common.MultiboardSetItemsIcon(lb, iconPath);

        /// <summary>保存多面板到哈希表.</summary>
        public static bool SaveHandle(this multiboard whichMultiboard, hashtable table, int parentKey, int childKey) => Common.SaveMultiboardHandle(table, parentKey, childKey, whichMultiboard);

        /// <summary>从哈希表提取多面板.</summary>
        public static multiboard LoadHandle(hashtable table, int parentKey, int childKey) => Common.LoadMultiboardHandle(table, parentKey, childKey);

        #region multiboarditem

        /// <summary>获取多面板的指定行列的项目.</summary>
        public static multiboarditem GetItem(this multiboard lb, int row, int column) => Common.MultiboardGetItem(lb, row, column);

        /// <summary>释放多面板的指定项目.</summary>
        public static void ReleaseItem(this multiboarditem mbi) => Common.MultiboardReleaseItem(mbi);

        /// <summary>设置多面板的指定项目的风格(显示 值, 图标).</summary>
        public static void SetItemStyle(this multiboarditem mbi, bool showValue, bool showIcon) => Common.MultiboardSetItemStyle(mbi, showValue, showIcon);

        /// <summary>设置多面板的指定项目的值.</summary>
        public static void SetItemValue(this multiboarditem mbi, string val) => Common.MultiboardSetItemValue(mbi, val);

        /// <summary>设置多面板的指定项目的值颜色.</summary>
        public static void SetItemValueColor(this multiboarditem mbi, int red, int green, int blue, int alpha) => Common.MultiboardSetItemValueColor(mbi, red, green, blue, alpha);

        /// <summary>设置多面板的指定项目的宽度.</summary>
        public static void SetItemWidth(this multiboarditem mbi, float width) => Common.MultiboardSetItemWidth(mbi, width);

        /// <summary>设置多面板的指定项目的图标.</summary>
        public static void SetItemIcon(this multiboarditem mbi, string iconFileName) => Common.MultiboardSetItemIcon(mbi, iconFileName);

        /// <summary>保存多面板项目到哈希表.</summary>
        public static bool SaveHandle(this multiboarditem whichMultiboarditem, hashtable table, int parentKey, int childKey) => Common.SaveMultiboardItemHandle(table, parentKey, childKey, whichMultiboarditem);

        /// <summary>从哈希表提取多面板项目.</summary>
        public static multiboarditem LoadItemHandle(hashtable table, int parentKey, int childKey) => Common.LoadMultiboardItemHandle(table, parentKey, childKey);

        #endregion

        /// <summary>显示/隐藏多面板模式.</summary>
        public static void SuppressDisplay(bool flag) => Common.MultiboardSuppressDisplay(flag);

        #endregion
    }

    public static partial class MultiBoardHelper
    {
        #region Blizzard

        /// <summary>创建多面板.</summary>
        public static multiboard CreateBJ(int cols, int rows, string title) => Blizzard.CreateMultiboardBJ(cols, rows, title);

        /// <summary>销毁多面板.</summary>
        public static void DestroyBJ(this multiboard mb) => Blizzard.DestroyMultiboardBJ(mb);

        /// <summary>获取最后创建的多面板.</summary>
        public static multiboard GetLastCreated() => Blizzard.GetLastCreatedMultiboard();

        /// <summary>显示/隐藏多面板.</summary>
        public static void DisplayBJ(this multiboard mb, bool show) => Blizzard.MultiboardDisplayBJ(show, mb);

        /// <summary>最小化多面板.</summary>
        public static void MinimizeBJ(this multiboard mb, bool minimize) => Blizzard.MultiboardMinimizeBJ(minimize, mb);

        /// <summary>设置多面板的标题颜色.</summary>
        public static void SetTitleTextColorBJ(this multiboard mb, float red, float green, float blue, float transparency) => Blizzard.MultiboardSetTitleTextColorBJ(mb, red, green, blue, transparency);

        /// <summary>显示/隐藏所有多面板.</summary>
        public static void AllowDisplayBJ(bool flag) => Blizzard.MultiboardAllowDisplayBJ(flag);

        /// <summary>设置多面板的指定的行列的项目的风格(显示 值, 图标).</summary>
        public static void SetItemStyleBJ(this multiboard mb, int col, int row, bool showValue, bool showIcon) => Blizzard.MultiboardSetItemStyleBJ(mb, col, row, showValue, showIcon);

        /// <summary>设置多面板的指定的行列的项目的值.</summary>
        public static void SetItemValueBJ(this multiboard mb, int col, int row, string val) => Blizzard.MultiboardSetItemValueBJ(mb, col, row, val);

        /// <summary>设置多面板的指定的行列的项目的颜色.</summary>
        public static void SetItemColorBJ(this multiboard mb, int col, int row, float red, float green, float blue, float transparency) => Blizzard.MultiboardSetItemColorBJ(mb, col, row, red, green, blue, transparency);

        /// <summary>设置多面板的指定的行列的项目的宽度.</summary>
        public static void SetItemWidthBJ(this multiboard mb, int col, int row, float width) => Blizzard.MultiboardSetItemWidthBJ(mb, col, row, width);

        /// <summary>设置多面板的指定的行列的项目的图标.</summary>
        public static void SetItemIconBJ(this multiboard mb, int col, int row, string iconFileName) => Blizzard.MultiboardSetItemIconBJ(mb, col, row, iconFileName);


        /// <summary>保存多面板到哈希表.</summary>
        public static bool SaveHandleBJ(this multiboard whichMultiboard, int key, int missionKey, hashtable table) => Blizzard.SaveMultiboardHandleBJ(whichMultiboard, key, missionKey, table);

        /// <summary>保存多面板项目到哈希表.</summary>
        public static bool SaveHandleBJ(this multiboarditem whichMultiboarditem, int key, int missionKey, hashtable table) => Blizzard.SaveMultiboardItemHandleBJ(whichMultiboarditem, key, missionKey, table);

        /// <summary>从哈希表提取多面板.</summary>
        public static multiboard LoadHandleBJ(int key, int missionKey, hashtable table) => Blizzard.LoadMultiboardHandleBJ(key, missionKey, table);

        /// <summary>从哈希表提取多面板项目.</summary>
        public static multiboarditem LoadItemHandleBJ(int key, int missionKey, hashtable table) => Blizzard.LoadMultiboardItemHandleBJ(key, missionKey, table);
        #endregion

    }
}
