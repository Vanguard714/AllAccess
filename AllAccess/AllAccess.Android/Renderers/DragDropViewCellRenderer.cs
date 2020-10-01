﻿using System;
using Xamarin.Forms;
using AllAccess.Droid.Renderers;
using AllAccess.Droid.Custom;
using Xamarin.Forms.Platform.Android;
using Android.Views;
using AllAccess.Controls;

[assembly: ExportRenderer(typeof(DragCell), typeof(DragDropViewCellRenderer))]
namespace AllAccess.Droid.Renderers
{
    public class DragDropViewCellRenderer:ViewCellRenderer
    {
        protected override global::Android.Views.View GetCellCore(Xamarin.Forms.Cell item, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent, global::Android.Content.Context context)
        {
            var cell = base.GetCellCore(item, convertView, parent, context) as ViewGroup;

            cell.SetOnDragListener(new ItemDragListener(cell));
            return cell;
        }
    }
}
