# CONTRIBUTING

## adding new architecture

### Steps

1. Choose rid from https://learn.microsoft.com/en-us/dotnet/core/rid-catalog#using-rids
2. Add new build step to https://github.com/ws-battleships/console-client/blob/master/.github/workflows/release.yml
3. Add rid to `needs` of the `create-tagged-release` build step

### File format
*replace \<RID\> with your chosen rid*
  
```yml
<RID>:
    name: "<RID>"
    runs-on: "ubuntu-latest"

    steps:
      - name: get version
        run: VERSION=${{ github.ref_name }} && echo "PROJ_VERSION=${VERSION:1}" >> $GITHUB_ENV
      - uses: actions/checkout@v3
      # Setup .Net
      - name: Setup .NET
        uses: actions/setup-dotnet@v3
        with:
          dotnet-version: 6.0.x
      # Restoring dependencies for <RID>
      - name: restore
        run: dotnet restore ConsoleClient --runtime <RID>
      # Running tests for <RID>
      - name: test
        run: dotnet test ConsoleClient --no-build --verbosity normal --runtime <RID>
      # Build <RID>
      - name: build
        run: dotnet build ConsoleClient -p:Version=${{ env.PROJ_VERSION }} --runtime <RID> --configuration Release --no-restore --self-contained
      # Create folder and bring output in correct format
      - name: organize
        run: mkdir -p out/ConsoleClient && cp ConsoleClient/bin/Release/net6.0/<RID>/* out/ConsoleClient
      - name: package
        run: cd out && zip -r <RID>.zip ConsoleClient/*
      - name: upload artifact
        uses: actions/upload-artifact@v3
        with:
          name: <RID>
          path: out/<RID>.zip
```
