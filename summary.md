---
layout: article
title: Articles summary
permalink: "/articlessummary.html"
---
{% for article in site.articles %}
	{% if forloop.index < 10 %}
		<a href="http://www.google.com">article.title</a>
	{% endif %}
{% endfor %}