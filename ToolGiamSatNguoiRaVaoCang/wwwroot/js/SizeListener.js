function MatchesQuery(mediaQuery, dotNetHelper) {
    var query = window.matchMedia(mediaQuery), pendingCall;
    handleQuery(query).then(function () {
        return query.addListener(handleQuery);
    });

    function handleQuery(queryMatch) {
        return (pendingCall || Promise.resolve(true))
            .then(function () {
                return pendingCall = new Promise(function (resolve, reject) {
                    dotNetHelper.invokeMethodAsync('OnQueryChanged', queryMatch.matches).then(resolve).catch(reject);
                });
            });
    }
}