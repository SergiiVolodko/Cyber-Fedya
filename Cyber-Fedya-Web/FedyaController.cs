﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Cyber_Fedya_Web.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Cyber_Fedya_Web
{
	[Route("api")]
	public class FedyaController : Controller
	{
		[HttpGet]
		[Route("vocabulary")]
		public WordsDto GetVocabulary()
		{
			return new WordsDto
			{
				Adjctives = new List<string>{"Кожанный", "Зелёный"},
				Names = new List<string>{"Олег", "Дмитрий Маликов"},
				Verbs = new List<string>{"есть","пить","быть","бить","брить","греть","лезть","ныть","лить","жить","крыть",},
				Nouns = new List<string> { "Ферзь" }
			};
		}

		//[HttpPost]
		//[Route("vocabulary")]
		//public HttpResponseMessage AddWord(NewWordDto dto)
		//{
		//	return new HttpResponseMessage(HttpStatusCode.BadRequest);
		//}

		[HttpGet]
		[Route("schemas")]
		public IList<SchemaDto> GetSchemas()
		{
			return new List<SchemaDto>
			{
				new SchemaDto
				{
					Id = "1",
					Name = "Персонаж",
					Words = new List<WordInScheme>{ new WordInScheme
					{
						Text = "<Персонаж>",
						OrderNumber = 1
					}}
				},
				new SchemaDto
				{
					Id = "2",
					Name = "777",
					Words = new List<WordInScheme>{
						new WordInScheme { Text = "У", OrderNumber = 1 },
						new WordInScheme { Text = "<Персонаж>", OrderNumber = 2 },
						new WordInScheme { Text = "такой", OrderNumber = 3 },
						new WordInScheme { Text = "<Прилагательное>", OrderNumber = 4 },
						new WordInScheme { Text = "<Существительное>", OrderNumber = 5 },
						new WordInScheme { Text = "что он", OrderNumber = 6 },
						new WordInScheme { Text = "<Глагол>", OrderNumber = 7 },
						new WordInScheme { Text = "в", OrderNumber = 8 },
						new WordInScheme { Text = "<Прилагательное>", OrderNumber = 9 },
						new WordInScheme { Text = "<Существительное>", OrderNumber = 10 }
					}
				},
			};
		}

		//[HttpPost]
		//[Route("schemas")]
		//public HttpResponseMessage CreateScheme(SchemaDto dto)
		//{
		//	return new HttpResponseMessage(HttpStatusCode.BadRequest);
		//}

		//[HttpPost]
		//[Route("sentenses")]
		//public HttpResponseMessage SaveSentence(string sentence)
		//{
		//	return new HttpResponseMessage(HttpStatusCode.BadRequest);
		//}
	}
}
