﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MuscleTrainingRecords00.sqlite;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList;
            itemList = await itemDataBase.GetItemsAsync();

            if (itemList.Count < 1)
            {
                await storeInitialData(itemDataBase);
                itemList = await itemDataBase.GetItemsAsync();
            }

            // ListViewを生成する
            listView.ItemsSource = itemList;
        }

        private static async Task storeInitialData(TrainingDatabase itemDataBase)
        {
            Training pushup = new Training() { Menu = "サイドレイズ", Load = "☆", parts = "肩" };
            await itemDataBase.InsertItemAsync(pushup);
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ボールクランチ（ボール）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ボールバイク（ボール）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "サイドバイク（ダンベル）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "バーティカルベンチレッグレイズ（バーベル）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルクランチ（ダンベル）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "メディシンボールロシアンツイスト（ボール）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "アブドミナルマシンクランチ（マシン）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ウェィテッドクランチ（プレート）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "プルアップニーレイズ（マシン）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "TRX　ニータック（ボール）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ハンギングレッグレイズ（マシン）", Load = "☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "アームカール（マシン）", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "インクラインダンベルカール（ダンベル）", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "コンセントレーションカール（ダンベル）", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ナロウベンチブレス（バーベル）", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "インクランダンベルフライ（ダンベル）", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルベンチブレス（ダンベル）", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "トライセプスキックバック", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "プリーチャーカール", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ケーブルプレス（マシン）", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ライイング　トライセプス　エクステンション（バーベル）", Load = "☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ベントオーバーロウ", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ベントバックエクステンション", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "懸垂（マシン）", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ワンハンドローイング（ダンベル）", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "スペインヒップリフト", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルロウ", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルアップライトロー（ダンベル）", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "シーテッドローイング", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "デッドリフト", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ラットブルダウン", Load = "☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ディップス", Load = "☆☆", parts = "肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ベントオーバーロウ", Load = "☆☆", parts = "背中" });

        }

        //SearchBarを押した時のイベントハンドラ
        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("", Select.Text, "OK");

            /*if (0<=Select.Text.IndexOf(array1))
            {   
            }
            else
            {
                this.listView.ItemsSource = "データがありません";
            }*/

        }

        private async void 全部_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsync();
            listView.ItemsSource = itemList;

        }

        private async void 腹_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("腹");

            listView.ItemsSource = itemList;
        }

        private async void 腕_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("腕");

            listView.ItemsSource = itemList;

        }

        private async void 背中_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("背中");
            listView.ItemsSource = itemList;
        }

        private async void 胸_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("胸");
            listView.ItemsSource = itemList;
        }

        private async void 肩_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("肩");
            listView.ItemsSource = itemList;
        }

        private async void 脚_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("脚");
            listView.ItemsSource = itemList;
        }



        private void Sort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //int s = Sort.SelectedIndex;
            String si = (String)Sort.SelectedItem;
            //if (si==0)
            if (si.Equals("五十音順"))
            {
                // 配列に値を入れる
                int[] array1 = new int[] { 5, 4, 3, 2, 1 };

                // ListViewを生成する
                listView.ItemsSource = array1;
            }
            else
            {
                // 配列に値を入れる
                int[] array1 = new int[] { 5, 4, 3, 2, 1 };

                // ListViewを生成する
                listView.ItemsSource = array1;
            }
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            // DisplayAlert("", , "OK");

            Training training = (Training)listView.SelectedItem;
            String l = training.Menu;

            Navigation.PushAsync(new MenudetaliPage(l));
        }
    }
}



