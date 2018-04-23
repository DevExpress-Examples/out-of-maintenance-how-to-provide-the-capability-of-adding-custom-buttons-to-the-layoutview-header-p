using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Layout;

namespace CustomButtonsLayoutView
{
    class LayoutViewCustomButtonSelectionInfo : LayoutViewSelectionInfo
    {
        public LayoutViewCustomButtonSelectionInfo(LayoutViewCustomButton gridView) : base(gridView) 
        {
            if (gridView != null && gridView.ButtonsCollection.Count > 0)
            {
                int[] myValidHotTracks = new int[fValidHotTracks.Length + gridView.ButtonsCollection.Count];
                int[] myValidPressedHitTests = new int[fValidHotTracks.Length + gridView.ButtonsCollection.Count];
                int[] myViewPressedStates = new int[fValidHotTracks.Length + gridView.ButtonsCollection.Count];
                Array.Copy(fValidHotTracks, myValidHotTracks, fValidHotTracks.Length);
                Array.Copy(fValidPressedHitTests, myValidPressedHitTests, fValidPressedHitTests.Length);
                Array.Copy(fViewPressedStates, myViewPressedStates, fViewPressedStates.Length);
                for (int i = 1; i <= gridView.ButtonsCollection.Count; i++)
                {
                    myValidHotTracks[fValidHotTracks.Length - 1 + i] = gridView.ButtonsCollection[i - 1].GetHashCode();
                    myValidPressedHitTests[fValidPressedHitTests.Length - 1 + i] = gridView.ButtonsCollection[i - 1].GetHashCode();
                    myViewPressedStates[fViewPressedStates.Length - 1 + i] = gridView.ButtonsCollection[i - 1].GetHashCode();
                }
                fValidHotTracks = myValidHotTracks;
                fValidPressedHitTests = myValidPressedHitTests;
                fViewPressedStates = myViewPressedStates;
            }        
        }
    }
}
