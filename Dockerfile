# Imagem de deploy
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS deploy-env
WORKDIR /app
COPY output/. .
COPY docker-entrypoint.sh .

ENV ATLAS_ENVIRONMENT "Production"

EXPOSE 80

HEALTHCHECK --start-period=5s --interval=2s --timeout=5s --retries=10 \
	CMD curl --fail http://localhost:80/health/live || exit 1

ENTRYPOINT ["bash", "docker-entrypoint.sh"]
CMD ["dotnet", "atlas.api.service-scheduler.dll"]
