﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace RecruiterApp
{
	public partial class ItemManager
	{
		static ItemManager defaultInstance = new ItemManager();
		MobileServiceClient client;
		IMobileServiceTable<TodoItem> todoTable;
		IMobileServiceTable<Position> positionTable;

		private ItemManager()
		{
			this.client = new MobileServiceClient(
				Constants.ApplicationURL);
			this.todoTable = client.GetTable<TodoItem>();
			try
			{
				//this.positionTable = client.GetTable<Position>();
			}
			catch (Exception ex)
			{

			}
		}

		public static ItemManager DefaultManager
		{
			get
			{
				return defaultInstance;
			}
			private set
			{
				defaultInstance = value;
			}
		}

		public MobileServiceClient CurrentClient
		{
			get { return client; }
		}

		public async Task<ObservableCollection<TodoItem>> GetTodoItemsAsync(bool syncItems = false)
		{
			try
			{
				IEnumerable<TodoItem> items = await todoTable
					.Where(todoItem => !todoItem.Done)
					.ToEnumerableAsync();

				return new ObservableCollection<TodoItem>(items);
			}
			catch (MobileServiceInvalidOperationException msioe)
			{
				Debug.WriteLine(@"Invalid sync operation: {0}", msioe.Message);
			}
			catch (Exception e)
			{
				Debug.WriteLine(@"Sync error: {0}", e.Message);
			}
			return null;
		}

		public async Task SaveTaskAsync(TodoItem item)
		{
			if (item.Id == null)
			{
				await todoTable.InsertAsync(item);
			}
			else
			{
				await todoTable.UpdateAsync(item);
			}
		}


		//Getting all current open positions
		public async Task<ObservableCollection<Position>> GetPositionItemsAsync(bool syncItems = false)
		{
			try
			{
				IEnumerable<Position> items = await positionTable
					.ToEnumerableAsync();

				return new ObservableCollection<Position>(items);
			}
			catch (MobileServiceInvalidOperationException msioe)
			{
				Debug.WriteLine(@"Invalid sync operation: {0}", msioe.Message);
			}
			catch (Exception e)
			{
				Debug.WriteLine(@"Sync error: {0}", e.Message);
			}
			return null;
		}

		//Saving a new Position
		public async Task SaveNewPositionAsync(Position position)
		{
			if (position.positionName == null)
			{
				await positionTable.InsertAsync(position);
			}
			else
			{
				await positionTable.UpdateAsync(position);
			}
		}
	}
}
