﻿using Matrimony.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Matrimony.ViewModels
{
    public class PhotosViewModel :INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        #region SelectedImage

        private ImageSource selectedImage =  ImageSource.FromFile("user_32px.png");

        public ImageSource SelectedImage
        {
            get { return selectedImage; }
            set
            {
                selectedImage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedImage"));
            }
        }

        #endregion
        private ObservableCollection<PhotosModel> image;


        public ObservableCollection<PhotosModel> Images
        {
            get { return image; }
            set { this.image = value; }
        }

        public PhotosViewModel()
        {
            GenerateSource();
        }

        private void GenerateSource()
        {

            List<PhotosModel> photosModels = new List<PhotosModel>()
                {
                    new PhotosModel()
                    {
                        Source="https://picsum.photos/400/700"
                    },
                    new PhotosModel()
                    { 
                     Source="https://picsum.photos/300/1800"
                    },
                    new PhotosModel()
                    {
                     Source="https://picsum.photos/400/600"
                    },
                    new PhotosModel()
                    {
                     Source="https://picsum.photos/1200/700"
                    },
                    new PhotosModel()
                    {
                     Source="https://picsum.photos/400/300"
                    },
                    new PhotosModel()
                    {
                     Source="https://picsum.photos/350/700"
                    },
                    new PhotosModel()
                    {
                     Source="https://picsum.photos/400/700"
                    },
                    new PhotosModel()
                    {
                     Source="https://picsum.photos/400/600"
                    },
                    new PhotosModel()
                    {
                     Source="https://picsum.photos/400/350"
                    },
                    new PhotosModel()
                    {
                     Source="https://picsum.photos/400/550"
                    },
                    new PhotosModel()
                    {
                     Source="https://picsum.photos/400/500"
                    }
                };

            Images = new ObservableCollection<PhotosModel>(photosModels);
            
        }
    }


}
