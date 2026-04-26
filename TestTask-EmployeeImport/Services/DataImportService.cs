using TestTask_EmployeeImport.Models;

namespace TestTask_EmployeeImport.Services
{
	public class DataImportService
	{
		public async Task FillEmployeeListAsync(IFormFile file, List<Employee> employees)
		{
			using (StreamReader reader = new StreamReader(file.OpenReadStream()))
			{
				await reader.ReadLineAsync();

				while (!reader.EndOfStream)
				{
					var line = await reader.ReadLineAsync();
					if (string.IsNullOrWhiteSpace(line)) continue;

					string[] values = line.Split(',');

					if (values.Length >= 11)
					{
						try
						{
							ParseAndAddEmployee(employees, values);
						}
						catch
						{
							continue;
						}
					}
				}
			}
		}

		private void ParseAndAddEmployee(List<Employee> employees, string[] values)
		{
			var employee = new Employee(
								values[0].Trim(),
								values[1].Trim(),
								values[2].Trim(),
								DateTime.Parse(values[3].Trim()),
								values[4].Trim(),
								values[5].Trim(),
								values[6].Trim(),
								values[7].Trim(),
								values[8].Trim(),
								values[9].Trim(),
								values[10].Trim()
							);

			employees.Add(employee);
		}
	}
}
