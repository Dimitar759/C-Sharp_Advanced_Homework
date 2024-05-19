using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace DataAccess
{
    public class StorageSet<T> : IStorageSet<T> where T : User
    {
        public List<T> Items { get; set; } = new List<T>();
        private readonly string _filePath;

        public StorageSet(string filePath)
        {
            _filePath = filePath;
            LoadFromFile();
        }

        public void Add(T entity)
        {
            if (entity.Id != 0)
            {
                throw new Exception("For adding new item, the Id needs to be set to 0");
            }

            if (Items.Any())
            {
                int max = Items.Max(x => x.Id);
                entity.Id = max + 1;
            }
            else
            {
                entity.Id = 1;
            }

            Items.Add(entity);
            SaveToFile();
        }

        public List<T> GetAll()
        {
            return Items;
        }

        public T GetById(int id)
        {
            T item = Items.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException($"Entity with Id = {id} does not exist");
            }

            return item;
        }

        public void Update(T entity)
        {
            T item = Items.FirstOrDefault(x => x.Id == entity.Id);

            if (item == null)
            {
                throw new KeyNotFoundException($"Entity with Id = {entity.Id} does not exist");
            }

            int index = Items.IndexOf(item);
            Items[index] = entity;
            SaveToFile();
        }

        public void Delete(T entity)
        {
            Delete(entity.Id);
        }

        public void Delete(int id)
        {
            T item = Items.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException($"Entity with Id = {id} does not exist");
            }

            Items.Remove(item);
            SaveToFile();
        }

        private void SaveToFile()
        {
            var json = JsonSerializer.Serialize(Items);
            File.WriteAllText(_filePath, json);
        }

        private void LoadFromFile()
        {
            if (!File.Exists(_filePath)) return;

            var json = File.ReadAllText(_filePath);
            var items = JsonSerializer.Deserialize<List<T>>(json);

            if (items != null)
            {
                Items = items;
            }
        }
    }

}